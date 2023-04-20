using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDataMvc.BusinessObjects
{
    public class Flower
    {

        public int ID { get; set; }

        public string Species { get; set; }

        public Color PrevailingColor { get; set; }



        public Flower()
        {
        }



        public Flower(int id, string species, Color prevailingColor)
        {
            this.ID = id;
            this.Species = species;
            this.PrevailingColor = prevailingColor;
        }


    }
}
