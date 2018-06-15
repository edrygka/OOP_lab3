using System;
namespace OOP_lab3
{
    public class BatchOfToys : ICloneable, IComparable
    {
        /*
         * BatchOfToys fields
         */
        private Toy toy;
        private float price;
        private int quantity;
        private DateTime date;

        /*
         * Constructors by default, with several params
         */
        public BatchOfToys()
        {
            toy = null;
            price = 0F;
            quantity = 0;
            date = DateTime.Now;
        }

        public BatchOfToys(Toy _toy)
        {
            toy = _toy;
            price = 0F;
            quantity = 1;
            date = DateTime.Now;
        }

        public BatchOfToys(Toy _toy, float _price)
        {
            toy = _toy;
            price = _price;
            quantity = 1;
            date = DateTime.Now;
        }

        public BatchOfToys(Toy _toy, float _price, int _quantity)
        {
            toy = _toy;
            price = _price;
            quantity = _quantity;
            date = DateTime.Now;
        }

        public BatchOfToys(Toy _toy, float _price, int _quantity, DateTime _date)
        {
            toy = _toy;
            price = _price;
            quantity = _quantity;
            date = _date;
        }

        /*
         * Getters and setters
         */
        public Toy Toy{
            get => toy;
            set => toy = value;
        }

        public float Price {
            get => price;
            set => price = value;
        }

        public int Quentity {
            get => quantity;
            set => quantity = value;
        }

        public DateTime Date {
            get => date;
            set => date = value;
        }

        public object Clone() => new BatchOfToys(toy, price, quantity, date);

        public override string ToString() => $"BatchOfToys:\nToy = {toy}, Price = {price}, Quantity = {quantity}, Date = {date}\n";

        public override int GetHashCode() => base.GetHashCode();

        public static explicit operator string(BatchOfToys _b) => _b.ToString();

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            BatchOfToys batch = obj as BatchOfToys;
            return (obj != null) && (Toy == batch.Toy) && (Price == batch.Price) && (Quentity == batch.Quentity) && (Date == batch.Date);
        }

        public static bool operator ==(BatchOfToys batch1, BatchOfToys batch2)
        {
            if (object.ReferenceEquals(batch1, null))
            {
                return object.ReferenceEquals(batch2, null);
            }
            return batch1.Equals(batch2);
        }

        public static bool operator !=(BatchOfToys batch1, BatchOfToys batch2)
        {
            return !batch1.Equals(batch2);
        }

        public static BatchOfToys operator +(BatchOfToys batch1, BatchOfToys batch2)
        {
            BatchOfToys batch = new BatchOfToys();
            batch.Price = batch1.Price + batch2.Price;
            batch.Quentity = batch1.Quentity + batch2.Quentity;
            return batch;
        }

        public static BatchOfToys operator -(BatchOfToys batch1, BatchOfToys batch2)
        {
            if (batch1.Price < batch2.Price) throw new Exception("First price is lower than second");
            if (batch1.Quentity < batch2.Quentity) throw new Exception("First quantity is lower than second");
            BatchOfToys batch = new BatchOfToys();
            batch.Price = batch1.Price - batch2.Price;
            batch.Quentity = batch1.Quentity - batch2.Quentity;
            return batch;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            BatchOfToys p = obj as BatchOfToys;
            if (p != null)
            {
                return price.CompareTo(p.price);
            }
            else throw new Exception("obj is not parcel");
        }

        /*
         * View function
         */
        public void View()
        {
            Console.WriteLine($"BatchOfToys:\nToy = {toy}, Price = {price}, Quantity = {quantity}, Date = {date}\n");
        }
    }
}
