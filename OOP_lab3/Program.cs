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
            Toy toy1 = new Toy();
            //toy.Provider = "first name";
            //Console.WriteLine(toy.Equals(toy1));
            //toy.View();
            BatchOfToys batch = new BatchOfToys(toy, 0.1F, 5, new DateTime(1998,12,21));
            BatchOfToys batch1 = new BatchOfToys(toy, 0.1F, 5, new DateTime(1998,12,22));
            //Console.WriteLine(batch != batch1);
            //batch.View();

            var storeOfToys = new List<BatchOfToys>
            {
                batch,
                new BatchOfToys(toy, 0.7F)
            };

            var storeOfToys1 = new List<BatchOfToys>
            {
                batch1,
                batch,
                new BatchOfToys(toy, 0.2F)
            };

            Store store = new Store(storeOfToys);
            Store store1 = new Store(storeOfToys);
            Console.WriteLine(store == store1);
            Console.WriteLine(store.Equals(store1));
            Console.WriteLine(batch.CompareTo(batch1));
            //Console.WriteLine(store1);

            //Store store = new Store(storeOfToys);
            //Console.WriteLine(store);
            //store.AddBatch(new BatchOfToys(new Toy("kek", "lol"), 0.5F, 5));
            //Console.WriteLine(store);

        }
    }
}
