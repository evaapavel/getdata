using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GetDataMvc.BusinessObjects;



namespace GetDataMvc.Services
{



    public class FlowerService
    {



        private List<Flower> flowers;



        public FlowerService()
        {
            PrepareData();
        }



        //private void PrepareData()
        private string PrepareData()
        {
            this.flowers = new List<Flower>();

            Flower daisy = new Flower(1, "Daisy", Color.Yellow);
            Flower rose = new Flower(2, "Rose", Color.Red);
            Flower lily = new Flower(3, "Lily", Color.White);

            this.flowers.Add(daisy);
            this.flowers.Add(rose);
            this.flowers.Add(lily);
        }




        public List<Flower> GetFlowers()
        {
            return this.flowers;
        }



        public Flower GetFlower(int id)
        {
            return this.flowers.First<Flower>(f => f.ID == id);
        }



    }



}
