using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ClientID = 1;
            client.ClientName = "Şule";
            client.ClientSurname = "Koca";

            Client client1 = new Client();
            client1.ClientID = 2;
            client1.ClientName = "Ayşe";
            client1.ClientSurname = "Kara";            


            ClientManager clientManager = new ClientManager();
            clientManager.AddClient(client);
            clientManager.AddClient(client1);
            clientManager.DeleteClient(client1);
            clientManager.UpdateClient(client1);

            Client[] clients = new Client[] { client, client1 };
            foreach(Client x in clients)
            {
                clientManager.ListClient(x);
                Console.WriteLine(x);
            }

        }
    }
}
