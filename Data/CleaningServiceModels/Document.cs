using System;
using System.Collections.Generic;

#nullable disable

namespace CleaningServiceWeb.Data.CleaningServiceModels
{
    public partial class Document
    {
        public Document()
        {
            Cleanings = new HashSet<Cleaning>();
            Orders = new HashSet<Order>();
        }

        public int IdDoc { get; set; }
        public int IdEmp { get; set; }
        public DateTime DateOrder { get; set; }
        public double Price { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual ICollection<Cleaning> Cleanings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
