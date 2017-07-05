namespace WebApiTest.Models
{
    using System;
    using System.Collections.Generic;
    public class Employee
    {
        public Employee()
        {
            Subordinates = new List<Employee>();
            Orders = new List<Order>();
            Territories = new List<Territory>();
        }
        public int EmployeeID { get; set; }
        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        
        public string Title { get; set; }
        
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }
        
        public string Extension { get; set; }
        
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }

        public string PhotoPath { get; set; }

        public virtual ICollection<Employee> Subordinates { get; set; }
        public virtual Employee Manager { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
        
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
