using System;

class Program
{
    static void Main(string[] args)
    {
        //iterate through the list of videos and for each one, display
        //the title, author, lenght, number of comments, and list
        //out the comments for that video
        comments v1 = new comments();
        v1._title = "HOW TO DO A JIGSAW PUZZLE QUICKLY";
        v1._author = "Karen Puzzles";
        v1._length = 1792;
        
        Video v2 = new Video();
        v2._title = "One two three";
        v2._author = "Plain White Tees";
        v2._lenght = 180;

        Video v3 = new Video();
        v3._title = "The Biggest MYTH About Your Things";
        v3._author = "The Minimal Mom";
        v3._lenght = 884;
    }
}