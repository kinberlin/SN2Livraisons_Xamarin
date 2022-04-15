using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Repository
{
    public class LivraisonRepository
    {
        public static List<Livraison> Livraisons = new List<Livraison>
        { 
        new Livraison("001","Yassa",DateTime.Parse("01/12/2022"),new Commandes("001","Yassa",DateTime.Parse("01/12/2022"),"Anders","+2 985 688 36")),
        new Livraison("002","Bonaberi",DateTime.Parse("02/12/2022"),new Commandes("002","Bonaberi",DateTime.Parse("02/12/2022"),"Malex","+244 985 869 40")),
        new Livraison("003","Dakar",DateTime.Parse("03/12/2022"), new Commandes("003","Dakar",DateTime.Parse("03/12/2022"),"Paolo","+21 975 368 36"))
        };

        public LivraisonRepository()
        {
        }

    }
}
