using MongoDB.Driver;
using Shared.Entities;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DataAccessLayer
{
    public class DALEmployeesMongo : IDALEmployees
    {
        private IMongoCollection<BsonDocument> collection;

        public DALEmployeesMongo()
        {
            IMongoDatabase database = MongoDBUtil.getMongoDB();
            collection = database.GetCollection<BsonDocument>("EmployeesTPH");
        }

        public void AddEmployee(Employee emp)
        {
            if (emp.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT = (FullTimeEmployee)emp;
                BsonDocument employee = new BsonDocument
                 {
                       {"empName",empFT.Name},
                       {"_id", MongoDBUtil.getNextSequence("EmployeesTPHId")},
                       {"salary",empFT.Salary},
                       {"startDate", empFT.StartDate},
                       {"TYPE_EMP",1}
                 };
                //collection.Database.
                collection.InsertOne(employee);
            }
            else if (emp.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empPT = (PartTimeEmployee)emp;
                BsonDocument employee = new BsonDocument
                 {
                       {"empName",empPT.Name},
                       {"_id", MongoDBUtil.getNextSequence("EmployeesTPHId")},
                       {"HourlyRate",empPT.HourlyRate},
                       {"startDate", empPT.StartDate},
                       {"TYPE_EMP",2}
                 };
                collection.InsertOne(employee);

            }
        }

        public void DeleteEmployee(int id)
        {
            //FilterDefinition<BsonDocument> filter = new BsonDocument{{"_id", id}};
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id",id);
            collection.DeleteOne(filter);
        }

        public void UpdateEmployee(Employee emp)
        {

            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", emp.Id);
            if (emp.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT = (FullTimeEmployee)emp;
                BsonDocument employee = new BsonDocument
                 {
                       {"empName",empFT.Name},
                       {"_id",empFT.Id},
                       {"salary",empFT.Salary},
                       {"startDate", empFT.StartDate},
                       {"TYPE_EMP",1}
                 };
                //FilterDefinition<BsonDocument> filter = "empId";
                collection.UpdateOne(filter, employee);
            }
            else if (emp.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empPT = (PartTimeEmployee)emp;
                BsonDocument employee = new BsonDocument
                 {
                       {"empName",empPT.Name},
                       {"_id",empPT.Id},
                       {"HourlyRate",empPT.HourlyRate},
                       {"startDate", empPT.StartDate},
                       {"TYPE_EMP",2}
                 };
                //FilterDefinition<BsonDocument> filter = "empId";
                collection.UpdateOne(filter, employee);

            }
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listReturn = new List<Employee>();
            List<BsonDocument> listBase = collection.Find<BsonDocument>(_=>true).ToList<BsonDocument>();
            //List<EmployeesTPH> listBase = dbContext.EmployeesTPH.ToList();
            foreach (BsonDocument employeesTPH in listBase)
            {
                listReturn.Add(convertBsonToEmployee(employeesTPH));
            }
            return listReturn;
        }

        public Employee GetEmployee(int id)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            BsonDocument employee = collection.Find<BsonDocument>(filter).First();
            return convertBsonToEmployee(employee);
        }

        private Employee convertBsonToEmployee(BsonDocument employee)
        {
            switch (employee["TYPE_EMP"].AsInt32)
            {
                case 1:
                    FullTimeEmployee returnEmployeeFT = new FullTimeEmployee();
                    returnEmployeeFT.Id = employee["_id"].AsInt32;
                    returnEmployeeFT.Name = employee["empName"].AsString;
                    returnEmployeeFT.Salary = Convert.ToInt32(employee["salary"].AsInt32);
                    returnEmployeeFT.StartDate = employee["startDate"].AsDateTime;
                    return returnEmployeeFT;
                case 2:
                    PartTimeEmployee returnEmployeePT = new PartTimeEmployee();
                    returnEmployeePT.Id = employee["_id"].AsInt32;
                    returnEmployeePT.Name = employee["empName"].AsString;
                    returnEmployeePT.HourlyRate = employee["HourlyRate"].AsDouble;
                    returnEmployeePT.StartDate = employee["startDate"].AsDateTime;
                    return returnEmployeePT;
                default:
                    return null;   
            }

            throw new NotImplementedException();
        }
    }
}
