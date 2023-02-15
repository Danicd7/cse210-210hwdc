using System;
class Comments 
{
    public string _commenterAuthor = ""; 
    public string _comment = "";

    //display the comments 
    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commenterAuthor}");
        Console.WriteLine($"Comment: {_comment}");
    }


}