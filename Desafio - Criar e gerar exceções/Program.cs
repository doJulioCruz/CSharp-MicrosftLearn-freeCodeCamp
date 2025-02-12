using System;

class Program
{
    static void Main()
    {
        string[][] userEnteredValues = new string[][]
        {
            new string[] { "1", "2", "3" },
            new string[] { "1", "two", "3" },
            new string[] { "0", "1", "2" }
        };

        try
        {
            Workflow1(userEnteredValues);
            Console.WriteLine("Workflow1 completed successfully.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred during 'Workflow1'.");
            Console.WriteLine(ex.Message);
        }
    }

    static void Workflow1(string[][] userEnteredValues)
    {
        try
        {
            foreach (string[] userEntries in userEnteredValues)
            {
                Process1(userEntries);
                Console.WriteLine("'Process1' completed successfully.\n");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }

    static void Process1(string[] userEntries)
    {
        foreach (string userValue in userEntries)
        {
            if (!int.TryParse(userValue, out int valueEntered))
            {
                throw new FormatException("Invalid data. User input values must be valid integers.");
            }

            if (valueEntered == 0)
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
    }
}
