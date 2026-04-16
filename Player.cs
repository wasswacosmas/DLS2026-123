using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Player(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty.");
        if (age < 1 || age > 40) throw new ArgumentException("Age must be between 1 and 40.");

        Name = name;
        Age = age;
    }

    public void UpdateAge(int newAge)
    {
        if (newAge < 1 || newAge > 40) throw new ArgumentException("Age must be between 1 and 40.");
        Age = newAge;
    }

    public string GetPlayerInfo() => $"Name: {Name}, Age: {Age}";
}