using System;
using System.Collections.Generic;

#nullable disable

namespace CleaningServiceWeb.Data.CleaningServiceModels
{
    public partial class Client
    {
        public Client()
        {
            Cleanings = new HashSet<Cleaning>();
            Orders = new HashSet<Order>();
        }

        public int IdClient { get; set; }
        public string NameCompany { get; set; }
        public string Address { get; set; }
        public string Fioagent { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Cleaning> Cleanings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
