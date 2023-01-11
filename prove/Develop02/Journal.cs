using System;

public class Journal

{
    public List<Entry> _adding_an_entry = new List<Entry>();
    public List<Entry> _displaying_entries = new List<Entry>();
    public List<Entry> _saving_to_file = new List<Entry>();
    public List<Entry> _Loading_file = new List<Entry>();

    public void Dispaly()
    {
        Console.WriteLine($"Type 1 to entry:");
        Console.WriteLine($"Type 2 to Display entry:");
        Console.WriteLine($"Type 3 to save the file:");
        Console.WriteLine($"Type 4 to load a file:");
    }
}