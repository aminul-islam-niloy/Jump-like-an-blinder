using OOP_and_Advance.Extra_location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance
{
    class Car
    {
        public string model;
        public int age;
        public string properties;

        public void  display_print()
        {
            Console.WriteLine(model + "  is an awesome " + properties +  " with " + age + " Years "); ;
        }

        public Car(string model, int age, string properties)
        {
            this.model = model;
            this.age = age; 
            this.properties = properties;
        }
    }

    internal class Program
    {
        static void Main(string[] args)

        {

           Car vehi = new Car("Honda", 5, " Car");
            vehi.display_print();

            Car pet = new Car("PomPom", 30, "Big");
            pet.display_print();

            string[] cars = { "AUdi", "BMW", "Tesla", "Honda" };
            // cars[2] = "Swopnil";
            // Console.WriteLine(cars[2]);

            string n1 = "Amin";
            string n2 = " Islam";




            string res= string.Concat(n1, n2);

          
            List<string> list = new List<string>();
             
            list.Add("Apple");
            list.Add("Mango");
            list.Add("banana");


            for(int i=0; i<list.Count; i++)
            {
               // Console.WriteLine(list[i]);
            }

            //var result = math.add(10, 13);
            //Console.WriteLine(result);

            // var season = Season.winter;


            //  switch (season)
            //  {
            // case Season.summer:
            //   Console.WriteLine("Hot");
            //    break;
            // case Season.winter:
            //     Console.WriteLine("cold");

            //    break;
            // case Season.rain:
            //    Console.WriteLine("rain");

            //    break;
            // case Season.spring:
            //     Console.WriteLine("awesome weaher");

            //    break;
            //   case Season.autumn:
            //      Console.WriteLine("water in river");

            //      break;
            //    default:
            //      Console.WriteLine("Not a season");

            //      break;

            age(2023, 1999);

            Console.ReadLine();



        }

        public static void age(int current, int year)

        {
            int total_age = current - year;
         //   Console.WriteLine(total_age);
            Console.ReadLine();
        }

        }
    }

