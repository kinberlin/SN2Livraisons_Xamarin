using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Livraison
    {
        public string Reference { get; set; }
        public string Lieu { get; set; }
        public DateTime DateHeure { get; set; }
        public bool Effectuer { get; set; }
        public Commandes Command { get; set; }

        public Livraison(string reference, string lieu, DateTime dateHeure)
        {
            Effectuer = false;
            Reference = reference;
            Lieu = lieu;
            DateHeure = dateHeure;
        }
        public Livraison() { }

        public Livraison(string reference, string lieu, DateTime dateHeure, Commandes command) : this(reference, lieu, dateHeure)
        {
            Command = command;
        }
    }
}
