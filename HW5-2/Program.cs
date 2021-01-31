using System;
//CONSTRUCTORS

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 1, FirstName = "Aygul", LastName = "Dikmen", City = "Adana" };
            Customer customer2 = new Customer(2, "Engin", "Demiroğ", "Ankara" );
        }
    }

    class Customer
    {
        //Biz yazmazsak arka planda default const. çalışır
        public Customer()//consturctor. Bir metot gibi çalışır
        {
            Console.WriteLine("Yapıcı fonksiyon çalıştı.");
        }
        public Customer(int id, string firstName, string lastName, String city)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
