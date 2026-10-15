using System;
using System.Collections.Generic;
using System.Text;

using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Services;

public class LearnerService
{
    private Dictionary<string, Learner> learners = new();

    public Dictionary<string, Learner> GetLearners()
    {
        return learners;
    }

    public void Register()
    {
        string id = "";

        while (string.IsNullOrWhiteSpace(id))
        {
            Console.Write("Enter Learner ID: ");
            id = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(id))
                Console.WriteLine("Invalid ID!");
        }

        if (learners.ContainsKey(id))
        {
            Console.WriteLine("Learner ID already exists!");
            return;
        }

        string name = "";

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Enter Learner Name: ");
            name = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(name))
                Console.WriteLine("Invalid Name!");
        }

        Console.Write("Enter Contact Number: ");
        string contact = Console.ReadLine() ?? "";

        Console.Write("Enter Email: ");
        string email = Console.ReadLine() ?? "";

        learners.Add(id, new Learner(id, name, contact, email));

        Console.WriteLine("Learner registered successfully!");
    }

    public void Display()
    {
        foreach (Learner learner in learners.Values)
        {
            Console.WriteLine(
                $"{learner.LearnerId} | {learner.Name} | " +
                $"{learner.ContactNumber} | {learner.Email}");
        }
    }

    public void Search()
    {
        Console.Write("Enter Learner ID: ");
        string id = Console.ReadLine() ?? "";

        if (learners.TryGetValue(id, out Learner? learner))
        {
            Console.WriteLine($"{learner.LearnerId} | {learner.Name} | {learner.Email}");
        }
        else
        {
            Console.WriteLine("Learner not found!");
        }
    }
}

