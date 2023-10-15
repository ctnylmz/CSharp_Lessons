//using System;

//namespace _4DayHomeWork
//{
//    internal class ValueAndReference
//    {
//        static void Main(string[] args)
//        {
//            //int number1 = 10;
//            //int number2 = 20;

//            //number1 = number2;

//            //number2 = 100;

//            //Console.WriteLine("Sayı 1 : " + number1);

//            //int[] numbers1 = new int[]
//            //{
//            //    1,2, 3
//            //};

//            //int[] numbers2 = new int[]
//            //{
//            //    10,20,30
//            //};

//            //numbers1 = numbers2;

//            //numbers2[0] = 1000;

//            //Console.WriteLine("Number 1" + ":" +numbers1[0]);



//            Person person1 = new Person();
//            person1.Firstname = "Engin";

//            Person person2 = new Person();

//            person2 = person1;

//            person1.Firstname = "CETIN";

//            Console.WriteLine(person2.Firstname);


//            Customer customer = new Customer();
//            customer.Firstname = "YILMAZ";

//            Employee employee = new Employee();

//            Person person3 = customer;

//            Console.WriteLine(person3.Firstname);

//            PersonManager manager = new PersonManager();

//            manager.Add(customer);


//        }

//    }
//    class Person
//    {
//        public int id { get; set; }
//        public string Firstname { get; set; }
//        public string Lastname { get; set; }

//    }

//    class Customer : Person
//    {
//        public string CreditCardNumber { get; set; }

//    }

//    class Employee : Person
//    {
//        public string EmployeeNumber { get; set; }
//    }

//    class PersonManager
//    {
//        public void Add(Person person)
//        {
//            Console.WriteLine(person.Firstname);
//        }
//    }
//}
