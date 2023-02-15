using System;

class Program
{
    static void Main(string[] args)
    {
        //iterate through the list of videos and for each one, display
        //the title, author, lenght, number of comments, and list
        //out the comments for that video
        Comments commentsv1 = new Comments();
        video v1 = new video();
        v1._title = "HOW TO DO A JIGSAW PUZZLE QUICKLY";
        v1._author = "Karen Puzzles";
        v1._length = 1792;

        v1.DisplayInfo();
        
        Comments commentsv2 = new Comments();
        video v2 = new video();
        v2._title = "One two three";
        v2._author = "Plain White Tees";
        v2._length = 180;

        Comments commentsv3 = new Comments();
        video v3 = new video();
        v3._title = "The Biggest MYTH About Your Things";
        v3._author = "The Minimal Mom";
        v3._length = 884;
    }


}