using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Controllers.models
{
    public class iservermanager
    {
       public static List<server> allserverslist = new List<server>();
        public server GetServer(string id)
        {
            return allserverslist.Find(item => item.ServerId == id);
        }
        public List<server> getallservers()
        {
            return allserverslist;
        }
        public void AddServer(server s)
        {
            allserverslist.Add(s);
        }
        public void deleteserver(string id)
        {
            server p = allserverslist.Where(x => x.ServerId == id).FirstOrDefault();
            if (p == null)
            {
                throw new Exception("id not found ");
            }
            else
            {
                allserverslist.Remove(p);
            }

        }
        public server getbyid(String id)
        {
            server p = allserverslist.Where(x => x.ServerId == id).FirstOrDefault();
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
