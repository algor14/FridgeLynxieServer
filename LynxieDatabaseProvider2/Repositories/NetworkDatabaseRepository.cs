using LynxieDatabaseProvider2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxieDatabaseProvider2.Repositories
{
    public class NetworkDatabaseRepository
    {
        public Network GetNetworkByName(string name, string pass)
        {
            using (var context = new LynxieDatabase())
            {
                return context.Network.FirstOrDefault(x => x.Name == name && x.Password == pass);
            }
        }

        public Network CreateNewNetwork(Network net)
        {
            Network tempNet = new Network();
            try
            {
                using (var context = new LynxieDatabase())
                {
                    tempNet.Name = net.Name;
                    tempNet.Password = net.Password;
                    tempNet.CreatorUserId = net.CreatorUserId;
                    context.Network.Add(tempNet);
                    context.SaveChanges();
                }
                UpdateUser(tempNet.CreatorUserId, tempNet.NetworkId);
            }
            catch (Exception e)
            {
                Logger.Log.Error($"Creating new network failed with exeption", e);
            }
            Logger.Log.Info($"New network was created succesfully. NetworkId: {tempNet.NetworkId}");
            return tempNet;
        }

        public bool IsNetworkExist(string name)
        {
            using (var context = new LynxieDatabase())
                foreach (var network in context.Network)
                    if (network.Name == name)
                        return true;
            return false;
        }

        //USER OPERATING PART
        public User CreateNewUser(User user)
        {
            Logger.Log.Info($"Create a new user: {user.Name}");
            User temp = new User();
            try
            {
                using (var context = new LynxieDatabase())
                {
                    temp.Name = user.Name;
                    context.User.Add(temp);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Logger.Log.Error($"Creating new user failed with exeption", e);
            }
            Logger.Log.Info($"New user was created succesfully. UserId: {temp.UserId}");
            return temp;
        }

        public void DeleteUsersNetwork(int creatorId)
        {
            try
            {
                using (var context = new LynxieDatabase())
                {
                    Network net = context.Network.SingleOrDefault(x => x.CreatorUserId == creatorId);
                    if (net != null)
                    {
                        context.Entry(net).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                        Logger.Log.Info($"Network has been deleted succesfully. UserId: {creatorId}");
                        return;
                    }                   
                }               
            }
            catch (Exception e)
            {
                Logger.Log.Error($"Deleting network failed with exeption", e);
            }
            Logger.Log.Error($"Could'n find network which would be created by User with id:{creatorId}");
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (var context = new LynxieDatabase())
                {
                    User user = context.User.SingleOrDefault(x => x.UserId == id);
                    if (user != null)
                    {
                        context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Log.Error($"Deleting user failed with exeption", e);
            }
            Logger.Log.Info($"User was deleted succesfully. UserId: {id}");
        }

        public bool UpdateUser(int id, int networkId)
        {
            try
            {
                using (var context = new LynxieDatabase())
                {
                    User user = context.User.SingleOrDefault(x => x.UserId == id);
                    if (user != null)
                    {
                        user.NetworkId = networkId;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Log.Error($"Creating new user failed with exeption", e);
                return false;
            }
            Logger.Log.Info($"New user was created succesfully. UserId: {id}");
            return true;
        }

    }
}
