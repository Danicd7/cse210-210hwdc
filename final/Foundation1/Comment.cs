using System;
class Comments 
{
    public string _commenterAuthor = ""; 
    public string _comment = "";


    //display the comments 
    public string DisplayComment()
    {
        return string.Format("Commenter: {0}, {1}", _commenterAuthor, _comment); 
    }


}