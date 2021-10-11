using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Models.InterfacesRepository
{
    public interface IClientRepository
    {
        List<Client> GetClients();
        Client GetClient(string id);
        Client Create(Client client);
        Client Update(Client client);
        Task Delete(string id);
    }
}
