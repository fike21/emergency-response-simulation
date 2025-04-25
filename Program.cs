using System;
using System.Collections.Generic;

abstract class EmergencyUnit
{
    public string Name { get; set; }
    public int Speed { get; set; }

    // Removed constructor — default one is used
    public abstract bool CanHandle(string incidentType);
    public abstract void RespondToIncident(string incidentType, string location);
}

class Police : EmergencyUnit
{
    public Police(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Crime", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(string incidentType, string location)
    {
        Console.WriteLine($"{Name} is handling crime at {location}.");
    }
}

class Firefighter : EmergencyUnit
{
    public Firefighter(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Fire", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(string incidentType, string location)
    {
        Console.WriteLine($"{Name} is extinguishing fire at {location}.");
    }
}

class Ambulance : EmergencyUnit
{
    public Ambulance(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Medical", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(string incidentType, string location)
    {
        Console.WriteLine($"{Name} is treating patients at {location}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<EmergencyUnit> units = new List<EmergencyUnit>
        {
            new Police("Police Unit 1", 90),
            new Firefighter("Firefighter Unit 1", 80),
            new Ambulance("Ambulance Unit 1", 100)
        };

        int score = 0;
        int totalRounds = 5;

        Console.WriteLine("Welcome to the Emergency Response Simulation!");
        Console.WriteLine("Valid incident types: Crime, Fire, Medical");

        for (int i = 1; i <= totalRounds; i++)
        {
            Console.WriteLine($"\n--- Turn {i} ---");

            Console.Write("Enter incident type: ");
            string type = Console.ReadLine();

            if (!IsValidIncidentType(type))
            {
                Console.WriteLine("Invalid incident type! -5 points.");
                score -= 5;
                continue;
            }

            Console.Write("Enter incident location: ");
            string location = Console.ReadLine();

            bool handled = false;

            foreach (var unit in units)
            {
                if (unit.CanHandle(type))
                {
                    unit.RespondToIncident(type, location);
                    Console.WriteLine("+10 points");
                    score += 10;
                    handled = true;
                    break;
                }
            }

            if (!handled)
            {
                Console.WriteLine("No unit available to handle this incident.");
                score -= 5;
            }

            Console.WriteLine($"Current Score: {score}");
        }

        Console.WriteLine($"\nFinal Score: {score}");
        Console.WriteLine("\nSimulation ended.");
    }

    static bool IsValidIncidentType(string type)
    {
        return type.Equals("Crime", StringComparison.OrdinalIgnoreCase) ||
               type.Equals("Fire", StringComparison.OrdinalIgnoreCase) ||
               type.Equals("Medical", StringComparison.OrdinalIgnoreCase);
    }
}
