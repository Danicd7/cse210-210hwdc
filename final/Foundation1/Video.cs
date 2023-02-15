using System;
class video
{
    public string _title = ""; 
    public string _author = "";
    public int _length = 0; 
    public List<Comments> comments = new List<Comments>();

    public void Comments()
    {
        Comments entries = new Comments();
        entries.DisplayComment();
        comments.Add(entries);
    }

    public void NumOfComments()
    {
        foreach (Comments item in comments)
        {
            Console.WriteLine(comments.Count);
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Lenght in seconds: {_length}");
    }
}