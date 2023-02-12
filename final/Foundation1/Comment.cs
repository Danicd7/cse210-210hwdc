using System;
class Comments 
{
    private string _commenterAuthor = ""; 
    private string _comment = "";

    //display the comments 
    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commenterAuthor}");
        Console.WriteLine($"Comment: {_comment}");
    }

}