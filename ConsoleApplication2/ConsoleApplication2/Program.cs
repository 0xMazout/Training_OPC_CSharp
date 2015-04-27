using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez Saisir votre nom utilisateur");
            string UserName = Console.ReadLine();
            Console.WriteLine("Vous avez Saisi " + UserName);
            String WeekEndOrNot = null; 
            DayOfWeek day = DateTime.Now.DayOfWeek;
            switch(day)
            {

                
                case DayOfWeek.Thursday :
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                //    Console.WriteLine("Bonjour " + UserName);
                    WeekEndOrNot = "Semaine"; 
                    break;
                case DayOfWeek.Monday:
                    WeekEndOrNot = "Lundi";
                    break;
                case DayOfWeek.Friday:
              //      Console.WriteLine("");
                    WeekEndOrNot = "Vendredi";
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                 //   Console.WriteLine("Bon Week-end" + UserName);
                    WeekEndOrNot = "WeekEnd";
                    break;
                    
            }
            DateTime HeureCourrante =  DateTime.Now;
            if(HeureCourrante.Hour < 9 && HeureCourrante.Hour < 18 )
            {
                //Affiche Bonjour Manque le traitement Journalier au dessus
                if (WeekEndOrNot == "Semaine" || WeekEndOrNot == "Lundi" || WeekEndOrNot == "Vendredi")
                {
                    Console.WriteLine("Hello, Bonjour, Holà " + UserName);
                }
            }
            else
            {
                // Affiche Bonsoir Manque le traitement Journalier au dessus
                if (HeureCourrante.Hour > 9 && HeureCourrante.Hour < 18)
                {
                        Console.WriteLine("Good Evening, Bonsoir, Bun nit" + UserName);
                        
                    if (WeekEndOrNot == "WeekEnd" || WeekEndOrNot == "Vendredi" || WeekEndOrNot == "Lundi")
                    {
                        Console.WriteLine("Good Week-End , Bon Week-End, Buenas Fin de Semana" + UserName);
                    }
                }

            }
            Console.ReadLine();
        }
            public void AfficheBonjour()
            {
                Console.WriteLine("Hello, Bonjour , Holà" + Environment.UserName); 
            }
            public void AfficheBonsoir()
            {
                Console.WriteLine("Good Evening, Bonsoir, Bun nit" + Environment.UserName);
            }
            public void AfficheBonWeekEnd()
            {
                Console.WriteLine("Have a nice Week-end, Bon Week-end, Buena fin de semana" + Environment.UserName);
            }
        }
        enum WeekDays
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        } 
    }

