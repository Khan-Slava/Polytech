﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Polytech.DAL.Model;

namespace Polytech.DAL
{
    public class ServiceClient
    {
        public List<Client> GetAllClients()
        {
            List<Client> clients = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {

                clients = db.GetCollection<Client>("Client")
                    .FindAll()
                    .ToList();
            }
            return clients;
        }

        public Client GetClientById(int Id)
        {
            Client client = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {

                client = db.GetCollection<Client>("Client")
                    .FindById(Id);
            }
            return client;
        }



        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {

                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);

            }
            return true;
        }
    }
}
