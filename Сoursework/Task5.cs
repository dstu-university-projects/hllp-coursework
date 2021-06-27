using System;
using System.Collections.Generic;
using System.Linq;

namespace Сoursework
{
    public class Task5 : Task
    {
        public override int TaskNumber => 5;

        public override void Main()
        {
            var flights = new List<Aeroflot> {
                new Aeroflot("Домодедово", 5, "Ту-204"),
                new Aeroflot("Архангельск", 99, "Boeing-777"),
                new Aeroflot("Уфа", 4, "Boeing-717"),
                new Aeroflot("Грозный", 18, "Boeing-777"),
                new Aeroflot("Орск", 63, "Airbus A330"),
                new Aeroflot("Уфа", 13, "Airbus A220"),
                new Aeroflot("Платов", 1, "Airbus A330"),
            };
            var sortedFlights = flights.OrderBy(flight => flight.flightNumber);

            Console.WriteLine("Доступные рейсы:");
            foreach (Aeroflot flight in sortedFlights) { Console.WriteLine(flight.PresentationValue()); }
            Console.WriteLine();    

            Console.WriteLine("Введите пункт назанчения:");

            string destination;
            do
            {
                destination = Console.ReadLine();
            }
            while (destination == "");

            var selectedFlights = sortedFlights.Where(flight => flight.destinationAirport.ToLower() == destination.ToLower());
            if (selectedFlights.Any())
            {
                Console.WriteLine("\nСамолеты по назанчению " + destination + ":");
                foreach (Aeroflot flight in selectedFlights)
                {
                    Console.WriteLine(flight.PresentationValue());
                }
            }
            else
            {
                Console.WriteLine("Самолеты по назанчению " + destination + " не найдены.");
            }

        }

        class Aeroflot
        {
            public string destinationAirport { get; }
            public uint flightNumber { get; }
            public string planeType { get; }

            public Aeroflot(string destination, uint flightNumber, string planeType) {
                destinationAirport = destination;
                this.flightNumber = flightNumber;
                this.planeType = planeType;
            }

            public string PresentationValue()
            {
               return "#" + flightNumber + "\t" + planeType + "\t" + " -> " + destinationAirport;
            }

        }
    }
}
