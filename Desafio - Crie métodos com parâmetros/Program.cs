
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string corporateDomain = "contoso.com";



DisplayEmail(corporate, corporateDomain);

DisplayEmail(external, externalDomain);


void DisplayEmail(string[,] names, string domain)
{
    int rowCount = names.GetLength(0);

    for (int i = 0; i < rowCount; i++)
    {
        string lastName = names[i, 1].ToLower();
        string initialName = names[i, 0].Substring(0, 2).ToLower();

        string completeEmail = $"{initialName}{lastName}@{domain}";
        Console.WriteLine(completeEmail);
    }
}