using System;
using System.Collections.Generic;

namespace OOP_lab3
{
    public class Store : ICloneable
    {
        
        /*
         * Store fields
         */
        private static int quantity;
        private int count;
        private List<BatchOfToys> storeOfToys;

        /*
         * Store constructors without params and with one param
         */
        public Store()
        {
            count = quantity;
            ++quantity;
            storeOfToys = new List<BatchOfToys>();
        }

        public Store(List<BatchOfToys> _storeOfToys)
        {
            storeOfToys = _storeOfToys;
        }

        /*
         * Getters and setters
         */
        public List<BatchOfToys> StoreOfToys
        {
            get => storeOfToys;
            set => storeOfToys = value;
        } 

        /*
         * Add batch of toys into Store
         */
        public void AddBatch(BatchOfToys _b)
        {
            storeOfToys.Add(_b);
        }

        /*
         * Delete one batch of toys from Store
         */
        public void EraseBatch(BatchOfToys _b)
        {
            storeOfToys.Remove(_b);
        }

        public override string ToString()
        {
            string output = $"Store:\nQuantity = {quantity}, Count = {count}, ";
            storeOfToys.ForEach(i =>
            {
                output += (string)i;
            });
            return output;
        }

        public object Clone() => new Store(storeOfToys);

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Store store = obj as Store;
            return (obj != null) && (count == store.count) && (storeOfToys == store.storeOfToys);
        }

        public static bool operator ==(Store store1, Store store2)
        {
            if (object.ReferenceEquals(store1, null))
            {
                return object.ReferenceEquals(store2, null);
            }
            return store1.Equals(store2);
        }

        public static bool operator !=(Store store1, Store store2)
        {
            return !store1.Equals(store2);
        }

        public static Store operator +(Store store1, Store store2)
        {
            Store store = new Store();
            store1.storeOfToys.ForEach(i =>
            {
                store.storeOfToys.Add(i);
            });
            store2.storeOfToys.ForEach(i =>
            {
                store.storeOfToys.Add(i);
            });
            return store;
        }

        /*
         * View Store information
         */
        public void View()
        {
            Console.WriteLine($"Store:\nQuantity = {quantity}, Count = {count}, Store of toys = {storeOfToys}");
        }
    }
}
