using LynxieDatabaseProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxieDatabaseProvider.Repositories
{
    public class NetworkDatabaseRepository
    {
        public Network GetNetworkByName(string name)
        {
            using (var context = new LynxieDatabase())
            {
                return context.Network.FirstOrDefault(x => x.Name == name);
            }
        }

        public void CreateNewNetwork(Network net)
        {
            using (var context = new LynxieDatabase())
            {
                Network temp = new Network();
                temp.Name = net.Name;
                temp.Password = net.Password;
                temp.User.Add(net.User.ToList()[0]);
                context.Network.Add(temp);
                context.SaveChanges();
            }
        }

        public bool IsNetworkExist(string name)
        {
            bool exist = false;
            using (var context = new LynxieDatabase())
            {
                foreach (var network in context.Network)
                    if (network.Name == name)
                        exist = true;
            }
            return exist;
        }

        //USER OPERATING PART
        public User CreateNewUser(User user)
        {
            User temp = new User();
            using (var context = new LynxieDatabase())
            {
                
                temp.Name = user.Name;               
                context.User.Add(temp);
                context.SaveChanges();
            }
            return temp;
        }

    }
}
