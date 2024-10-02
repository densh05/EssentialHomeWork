using System;
using System.Reflection.Metadata;

namespace Essential1._3
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = "12345";
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Bogomolskaya";
            address.House = "10";
            address.Apartment = "7";

            Console.WriteLine("Information:");
            Console.WriteLine("Index:" + address.Index);
            Console.WriteLine("Country:" + address.Country);
            Console.WriteLine("Cirt:" + address.City);
            Console.WriteLine("Street:" + address.Street);
            Console.WriteLine("House:" + address.House);
            Console.WriteLine("Apartment:" + address.Apartment);

            Console.ReadKey();
        }
    }
}
