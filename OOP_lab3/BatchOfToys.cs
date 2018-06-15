using System;
namespace OOP_lab3
{
    public class BatchOfToys : ICloneable
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
            toy = new Toy();
            price = 0.3F;
            quantity = 1;
            date = DateTime.Now;
        }

        public BatchOfToys(Toy _toy)
        {
            toy = _toy;
            price = 0.3F;
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

        /*
         * View function
         */
        public void View()
        {
            Console.WriteLine($"BatchOfToys:\nToy = {toy}, Price = {price}, Quantity = {quantity}, Date = {date}\n");
        }
    }
}
