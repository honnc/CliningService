using System;
using System.Collections.Generic;

#nullable disable

namespace CleaningServiceWeb.Data.CleaningServiceModels
{
    public partial class Order
    {
        public Order()
        {
            Cleanings = new HashSet<Cleaning>();
        }

        public int IdOrder { get; set; }
        public int IdDoc { get; set; }
        public int IdEmp { get; set; }
        public int IdClient { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Document IdDocNavigation { get; set; }
        public virtual Employee IdEmpNavigation { get; set; }
        public virtual ICollection<Cleaning> Cleanings { get; set; }
    }
}
