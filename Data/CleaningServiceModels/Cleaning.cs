using System;
using System.Collections.Generic;

#nullable disable

namespace CleaningServiceWeb.Data.CleaningServiceModels
{
    public partial class Cleaning
    {
        public int IdClean { get; set; }
        public int IdOrder { get; set; }
        public int IdDoc { get; set; }
        public int IdClient { get; set; }
        public DateTime DateClining { get; set; }
        public int IdEml { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Document IdDocNavigation { get; set; }
        public virtual Employee IdEmlNavigation { get; set; }
        public virtual Order IdOrderNavigation { get; set; }
    }
}
