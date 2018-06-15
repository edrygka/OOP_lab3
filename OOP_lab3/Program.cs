using System;
using System.Collections.Generic;

namespace OOP_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Clasification clasification = Clasification.CONSTRUCTOR;

            Toy toy = new Toy();
            toy.Provider = "hui";
            //toy.View();
            BatchOfToys batch = new BatchOfToys();
            //batch.View();

            var storeOfToys = new List<BatchOfToys>
            {
                batch,
                new BatchOfToys(toy, 0.7F)
            };

            Store store = new Store(storeOfToys);
            Console.WriteLine(store);
            //store.AddBatch(new BatchOfToys(new Toy("kek", "lol"), 0.5F, 5));
            //Console.WriteLine(store);

        }
    }
}
