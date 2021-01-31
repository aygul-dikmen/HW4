using System;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678910";

            Person person1 = customer;

            Employee employee = new Employee();
            employee.FirstName = "Abc";

            PersonManager pm = new PersonManager();
            pm.Add(customer);
        
        }
    }
    //Base class: Person
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person);
        }
    }


}
