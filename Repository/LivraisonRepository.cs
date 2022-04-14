using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class LivraisonRepository
    {
        public static List<Commandes> CommandeList1 = new List<Commandes>
        {
            new Commandes("001","Yassa",DateTime.Parse("01/12/2022"),"Anders","+2 985 688 36"),
            new Commandes("001","Elfe",DateTime.Parse("01/12/2022"),"Malex","+244 985 869 40"),
            new Commandes("001","Ari",DateTime.Parse("01/12/2022"),"Freds","+50 751 122 364"),
        };
        public static List<Commandes> CommandeList2 = new List<Commandes>
        {
            new Commandes("002","Ndokoti",DateTime.Parse("02/12/2022"),"Marianes","+2 985 688 36"),
            new Commandes("002","Bonaberi",DateTime.Parse("02/12/2022"),"Malex","+244 985 869 40"),
            new Commandes("002","Bonaberi",DateTime.Parse("02/12/2022"),"Freds","+50 751 122 364"),
        };
        public static List<Commandes> CommandeList3 = new List<Commandes>
        {
            new Commandes("002","Dakar",DateTime.Parse("03/12/2022"),"Paolo","+21 975 368 36"),
            new Commandes("002","Akwa",DateTime.Parse("03/12/2022"),"Marco","+24 985 753 40"),
            new Commandes("002","Terminus",DateTime.Parse("03/12/2022"),"adelaide","+50 714 122 364"),
        };

        public List<Livraison> Livraisons = new List<Livraison>
        { 
        new Livraison("001","Yassa",DateTime.Parse("01/12/2022").ToString(),CommandeList1),
        new Livraison("002","Yassa",DateTime.Parse("02/12/2022").ToString(),CommandeList2),
        new Livraison("003","Yassa",DateTime.Parse("03/12/2022").ToString(),CommandeList3),
        new Livraison("004","Yassa",DateTime.Parse("03/12/2022").ToString(),CommandeList3)
        };

        public List<Livraison> Noneffectuer() {
            var livs = new List<Livraison>();
            foreach(Livraison liv in Livraisons)
            {
                if (!liv.Effectuer)
                {
                    livs.Add(liv);
                }
            }
            return livs;
        
        }
    }
}
