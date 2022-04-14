using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Livraison
    {
        public string Reference;
        public string Lieu;
        public DateTime DateHeure;
        public string DateHeures;
        public bool Effectuer;
        public List<Commandes> CommandList;

        public Livraison(string reference, string lieu, DateTime dateHeure)
        {
            Effectuer = false;
            Reference = reference;
            Lieu = lieu;
            DateHeure = dateHeure;
        }
        public Livraison() { }

        public Livraison(string reference, string lieu, DateTime dateHeure, List<Commandes> commandList) : this(reference, lieu, dateHeure)
        {
            CommandList = commandList;
        }
        public Livraison(string reference, string lieu, string dateHeure, List<Commandes> commandList) 
        {
            CommandList = commandList;
            Effectuer = false;
            Reference = reference;
            Lieu = lieu;
            DateHeures = dateHeure;
        }
    }
}
