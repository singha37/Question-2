using System;


namespace ques2
{
    class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int YearOfBirth {get;set;}

            public Person(string fname, string lname)
            {
                FirstName = fname;
                LastName = lname;
            }

            public string GetFullName()
            {
                string FullName = FirstName + " " + LastName;
                return FullName;
            }
            
            public int GetAge()
            {
                return (2018 - YearOfBirth);
            }
        }
        static void Main(string[] args)
        {
            string fname, lname;
            Console.WriteLine("Enter name of new person below");
             Console.WriteLine("");
            Console.Write("First Name: ");
            fname = (Console.ReadLine());
            Console.Write("Last Name: ");
            lname = (Console.ReadLine());
            Person person = new Person(fname, lname);
            Console.Write("Enter Year Of Birth: ");
            person.YearOfBirth = Int32.Parse((Console.ReadLine()));
            string desc = "Person: " + person.GetFullName() + " is " + person.GetAge() + " years old";
            Console.WriteLine(desc);
            Console.ReadKey();
        }
    }
}
