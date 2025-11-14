public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string GetEntryAsString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
