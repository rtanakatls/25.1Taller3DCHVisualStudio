using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Week1
{
    internal class MenuWeek1 : Menu
    {
        private List<Person> people;

        public MenuWeek1()
        {
            people=new List<Person>();
        }

        public override void Execute()
        {
            ShowPersonMenu();
        }

        private void ShowPersonMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción");
                Console.WriteLine("1. Añadir una persona");
                Console.WriteLine("2. Mostrar todas las personas");
                Console.WriteLine("0. Salir");

                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        ShowPeople();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }
        }

        private void AddPerson()
        {
            string name;
            int age;

            name = GetName();
            age = GetAge();
            Person person = new Person(name, age);
            people.Add(person);
        }

        private void ShowPeople()
        {
            foreach (Person person in people) 
            {
                Console.WriteLine($"Hay una persona con nombre {person.Name} y edad {person.Age} años");
            }
        }

        private string GetName()
        {
            string name;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            return name;
        }

        private int GetAge()
        {
            int age;
            bool continueFlag;
            continueFlag = true;
            age = 0;

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                if (age >= 0)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Tu edad no puede ser negativa");
                }
            }
            return age;
        }

    }
}
