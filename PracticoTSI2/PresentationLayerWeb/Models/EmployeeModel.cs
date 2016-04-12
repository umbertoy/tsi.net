using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayerWeb.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Type { get; set; }
        public int Salary { get; set; }
        public double HourlyRate { get; set; }
    }
}