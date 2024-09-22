string[] addresses = {
    "123 Elm Street",
    "531 Oak Street",
    "678 Maple Street"
};

string street = "Elm Street";
//string street = "531 Oak Street";
//string street =  "678 Maple Street";
// Brute force (not recommended)
foreach (string address in addresses)
{
    int addressLength = address.Length;
    int streetLength = street.Length;
    for (int index = 0; index <= addressLength - streetLength; index++)
    {
        string substring = address.Substring(index, streetLength);
        if (substring == street)
        {
            Console.WriteLine(address);
        }
    }
}

// The IndexOf() method
foreach (string address in addresses)
{
    if (address.IndexOf(street) >= 0)
    {
        Console.WriteLine(address);
    }
}

// The Contains() method (preferred)
foreach (string address in addresses)
{
    if (address.Contains(street))
    {
        Console.WriteLine(address);
    }
}
