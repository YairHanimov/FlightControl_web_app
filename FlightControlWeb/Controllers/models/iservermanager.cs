using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class iservermanager
    {
        List<server> servers = new List<server>();
        public server GetServer(string id)
        {
            return servers.Find(item => item.ServerId == id);
        }
        public List<server> getallservers()
        {
            return servers;
        }
        public void AddServer(server s)
        {
            servers.Add(s);
        }
        public void deleteserver(string id)
        {
            server p = servers.Where(x => x.ServerId == id).FirstOrDefault();
            if (p == null)
            {
                throw new Exception("id not found ");
            }
            else
            {
                servers.Remove(p);
            }

        }
        public server getbyid(String id)
        {
            server p = servers.Where(x => x.ServerId == id).FirstOrDefault();
            if (p == null)
            {
                throw new Exception("id not found ");
            }
            else
            {
                return p;
            }
        }
    }
}
