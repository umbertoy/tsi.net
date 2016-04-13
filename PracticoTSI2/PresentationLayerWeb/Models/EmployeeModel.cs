using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public SelectListItem Type { get; set; }
        public List<SelectListItem> listItems { get; set; }
        public int Salary { get; set; }
        public double HourlyRate { get; set; }
    }
}