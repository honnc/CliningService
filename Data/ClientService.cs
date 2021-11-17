using CleaningServiceWeb.Data.CleaningServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningServiceWeb.Data
{
    public class ClientService
    {
        cleaning_serviceContext DB = new();
        public List<Client> GetClients()
        {
            return DB.Clients.ToList();
        }
    }
}
