using System;
namespace OOP_lab3
{
    public enum Clasification
        {
            SOFTTOY = 1,
            DOLL,
            TECHMODEL,
            CONSTRUCTOR
        } 
    public class Toy : ICloneable
    {
        /*
         * Toy fields 
         */
        private Clasification c;
        private string name;
        private string provider;

        /*
         * Constructors by default, with several params
         */
        public Toy()
        {
            name = "undefined";
            provider = "undefined";
            c = Clasification.TECHMODEL;
        }

        public Toy(string _name)
        {
            name = _name;
            provider = "undefined";
            c = Clasification.TECHMODEL;
        }

        public Toy(string _name, string _provider)
        {
            name = _name;
            provider = _provider;
            c = Clasification.TECHMODEL;
        }

        public Toy(string _name, string _provider, Clasification _c)
        {
            name = _name;
            provider = _provider;
            c = _c;
        }

        /*
         * Getter and setters
         */
        public string Name 
        {
            get => name;
            set => name = value;
        }

        public string Provider 
        {
            get => provider;
            set => provider = value;
        }

        private Clasification Clasification 
        {
            get => c;
            set => c = value;
        }

        public object Clone() => new Toy(name, provider, c);

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => $"Toy:\nName = {name}, Provider = {provider}, Classification = {c}";

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Toy toy = obj as Toy;
            return (obj != null) && (Provider == toy.Provider) && (Clasification == toy.Clasification) && (Name == toy.Name);
        }

        public static bool operator ==(Toy toy1, Toy toy2)
        {
            if (object.ReferenceEquals(toy1, null))
            {
                return object.ReferenceEquals(toy2, null);
            }
            return toy1.Equals(toy2);
        }

        public static bool operator !=(Toy toy1, Toy toy2)
        {
            return !toy1.Equals(toy2);
        }

        /*
         * View function
         */
        public void View(){
            Console.WriteLine($"Toy:\nName = {name}, Provider = {provider}, Classification = {c}");
        }

    }
}
