using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TeamSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"teamMembers.json");

            var givenList = new Reader().Read(jsonFilePath);

            var team = new TeamSetup(givenList);
            var teams = team.SetupTeams(3);

            Console.WriteLine("this is red team");
            foreach (var red in teams.Team[0])
            {
                Console.WriteLine($"Name: {red.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("this is white team");
            foreach (var white in teams.Team[1])
            {
                Console.WriteLine($"Name: {white.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("this is blue team");
            foreach (var blue in teams.Team[2])
            {
                Console.WriteLine($"Name: {blue.Name}");
            }
            Console.Read();
        }
    }
}
