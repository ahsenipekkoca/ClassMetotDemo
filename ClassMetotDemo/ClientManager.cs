using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {
        public void AddClient(Client client)
        {
            Console.WriteLine("Tebrikler, müşteri eklendi : " + client.ClientName+" "+client.ClientSurname);
        }
        public void DeleteClient(Client client)
        {
            Console.WriteLine("Müşteri başarıyla silindi: " + client.ClientName + " " + client.ClientSurname);
        }
        public void ListClient(Client client)
        {
            Console.WriteLine("Müşteriler listelendi: " + client.ClientName + " " + client.ClientSurname);
        }
        public void UpdateClient(Client client)
        {
            Console.WriteLine("Tebrikler, müşteri güncellendi: " + client.ClientName + " " + client.ClientSurname);
        }
    }
}
