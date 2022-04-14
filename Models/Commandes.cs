using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Commandes : Livraison
    {
        public string Client;
        public string tel;

        public Commandes(string reference, string lieu, DateTime dateHeure,string client, string tel) : base(reference,lieu,dateHeure)
        {
            Client = client;
            this.tel = tel;
        }
    }
}
