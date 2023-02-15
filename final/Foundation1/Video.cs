using System;
class video
{
    public string _title = ""; 
    public string _author = "";
    public int _length = 0; 
    public int _NumOfComments = 0;

    public List<Comments> comments = new List<Comments>();

    public void Comments()
    {
        Comments entries = new Comments();
        entries.DisplayComment();
        comments.Add(entries);
    }

    public int NumOfComments()
    {
        foreach (Comments item in comments)
        {
           _NumOfComments = comments.Count();
        }
       return _NumOfComments; 
    }
    public string DisplayInfo()
    {
        return String.Format("Title: {0}, Author: {1}, Lenght in seconds: {2}, Number of commets: {3}", _title, _author, _length, NumOfComments());
    }

    
}