using System;

class Program
{
    static void Main(string[] args)
    {
        //iterate through the list of videos and for each one, display
        //the title, author, lenght, number of comments, and list
        //out the comments for that video
        Comments comments1v1 = new Comments();
        Comments comments2v1 = new Comments();
        Comments comments3v1 = new Comments();
        comments1v1._commenterAuthor = "Paul";
        comments1v1._comment = "Amazing";
        comments2v1._commenterAuthor = "Adele";
        comments2v1._comment = "Nice video";
        comments3v1._commenterAuthor = "Jackson";
        comments3v1._comment = "Just came here to see the comments";
        video v1 = new video();
        v1._title = "HOW TO DO A JIGSAW PUZZLE QUICKLY";
        v1._author = "Karen Puzzles";
        v1._length = 1792;

        v1.DisplayInfo();
        comments1v1.DisplayComment();
        
        Comments commentsv2 = new Comments();
        commentsv2._commenterAuthor = "Maria";
        commentsv2._comment = "Amazing";
        video v2 = new video();
        v2._title = "One two three";
        v2._author = "Plain White Tees";
        v2._length = 180;

        Comments commentsv3 = new Comments();
        commentsv2._commenterAuthor = "Maria";
        commentsv2._comment = "Amazing";
        video v3 = new video();
        v3._title = "The Biggest MYTH About Your Things";
        v3._author = "The Minimal Mom";
        v3._length = 884;
    }


}