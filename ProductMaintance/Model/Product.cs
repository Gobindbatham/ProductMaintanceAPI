using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMaintance.Model
{
    public class Product
    {
        //Message id
        public int Id { get; set; }

        //Mesage text
        public string Name { get; set; }

        //Message sender
        public string Cpmpany { get; set; }

        //Message time
        public DateTime DTime { get; set; }


    }
}
