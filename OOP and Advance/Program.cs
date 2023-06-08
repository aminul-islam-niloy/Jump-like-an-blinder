using OOP_and_Advance.Extra_location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_and_Advance
{

        //extra class out of main class
    class Car
    {
        public string model;
        public int age;
        public string properties;

        public void  display_print()
        {
           // Console.WriteLine(model + "  is an awesome " + properties +  " with " + age + " Years "); ;
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

            //Polymorphism and inheritance 

            var cardam = new List<Cardam>
            {
            new Audi(234,"blue","A9"),
            new Bmw(100,"white","22354")
            

            };

            foreach(var Cardam in cardam)
            {
                Cardam.repair();
                Cardam.Print_detals();
            }


            // get and set

            Get_set get_Set = new Get_set();
            get_Set.Debit(20000);

            //get_Set.income += 10000;
           
           // Console.WriteLine(get_Set.income);
            Console.ReadKey();



            // time and date

            Gatter_and_Settter get_time= new Gatter_and_Settter();

            get_time.Date_time();


            // OOP section

           Car vehi = new Car("Honda", 5, " Car");
            vehi.display_print();

            Car pet = new Car("Poli", 30, "Big");
            pet.display_print();

            string[] cars = { "AUdI", "BMW", "Tesla", "Honda" };
           
            // cars[2] = "Swopnil";
            // Console.WriteLine(cars[2]);

            string n1 = "Amin";
            string n2 = " Islam";





            // number and string section 

            string res= string.Concat(n1, n2);

          
            List<string> list = new List<string>();
             
            list.Add("Apple");
            list.Add("Mango");
            list.Add("banana");


            for(int i=0; i<list.Count; i++)
            {
               // Console.WriteLine(list[i]);
            }

          //  var result = math.add(10, 13);
            //Console.WriteLine(result);

             //var season = Season.winter;


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


        // method
        public static void age(int current, int year)

        {
            int total_age = current - year;
         //   Console.WriteLine(total_age);
            Console.ReadLine();
        }

        }
    }

