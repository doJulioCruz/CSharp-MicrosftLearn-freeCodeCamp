﻿/**/
// Criar um método com parâmetros

    int[] schedule = {800, 1200, 1600,2000};

    void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
    {
        int diff = 0;
        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        }
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        }

        for (int i = 0; i < times.Length; i++)
        {
            int newTime = ((times[i] + diff)) % 2400;
            Console.WriteLine($"{times[i]} -> {newTime}");
        }
    }

    DisplayAdjustedTimes(schedule, 6, -6);

   
// Entender o escopo do método

    string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

    DisplayStudents(students);
    DisplayStudents(new string[] {"Robert", "Vanya"});

    void DisplayStudents(string[] students)
    {
        foreach (string student in students)
        {
            Console.Write($"{student}, ");
        }
        Console.WriteLine();
    }


    double pi = 3.14159;
    PrintCircleAInfo(12);
    PrintCircleAInfo(24);

    void PrintCircleAInfo(int radius)
    {
        Console.WriteLine($"Circle with radius {radius}");
        PrintCircleArea(radius);
        PrintCircleCircunference(radius);
    }


    void PrintCircleArea(int radius)
    {
        double area = pi * (radius * radius);
        Console.WriteLine($"Area = {area}");
    }

    void PrintCircleCircunference(int radius)
    {
        double circumference = 2 * pi * radius;
        Console.WriteLine($"Circunference = {circumference}");
    }


// Usar parâmetros de tipo de referência e de valor

// Testar passagem por valor

    int a = 3;
    int b = 4;
     int c = 0;

     Multiply(a, b, c);
     Console.WriteLine($"global statement: {a} x {b} = {c}");

     void Multiply(int a, int b, int c)
     {
        c = a * b;
        Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
     }


// Teste aprovado por referência

    int[] array = {1, 2, 3, 4, 5};
    PrintArray(array);
    Clear(array);
    PrintArray(array);

    void PrintArray(int[] array)
    {
        foreach (int a in array)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }

    void Clear(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }



// Testes com cadeias de caracteres

    string status = "Healthy";
    
    Console.WriteLine($"Start: {status}");
    SetHealth(false);
    Console.WriteLine($"End: {status}");

    void SetHealth(bool isHealthy)
    {
        status = (isHealthy ? "Healthy" : "Unhealthy");
        Console.WriteLine($"Middle: {status}");
    }


// Criar um aplicativo RSVP - Nesta tarefa, você criará um breve aplicativo para convidados para RSVP a um evento.

    string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
    string[] rsvps = new string[10];
    int count = 0;

    RSVP("Rebecca");
    RSVP("Nadia", 2,"Nuts");
    RSVP("Linh", partySize: 2, "none", inviteOnly: false);
    RSVP("Tony", 1, allergies: "Jackfruit", inviteOnly: true);
    RSVP("Noor", 4, "none", inviteOnly: false);
    RSVP("Jonte", 2, "Stone fruit", false);
    ShowRSVPs();


    void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
    {
        if (inviteOnly)
        {
            bool found = false;
            foreach (string guest in guestList)
            {
                if (guest.Equals(name))
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
        }

        rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
        count++;
    }

    void ShowRSVPs()
    {
        Console.WriteLine("\nTotal RSVPs:");
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine(rsvps[i]);
        }
    }

