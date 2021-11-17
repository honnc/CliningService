using System;
using System.Collections.Generic;

#nullable disable

namespace CleaningServiceWeb.Data.CleaningServiceModels
{
    public partial class Employee
    {
        public Employee()
        {
            Cleanings = new HashSet<Cleaning>();
            Documents = new HashSet<Document>();
            Orders = new HashSet<Order>();
        }

        public int IdEmp { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Cleaning> Cleanings { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
