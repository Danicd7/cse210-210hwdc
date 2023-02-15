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


        v1.comments.Add(comments1v1);
        v1.comments.Add(comments2v1);
        v1.comments.Add(comments3v1);

        v1.DisplayInfo();
        
        Comments commentsv2 = new Comments();
        commentsv2._commenterAuthor = "Antonia";
        commentsv2._comment = "Amazing";
        video v2 = new video();
        v2._title = "One two three";
        v2._author = "Plain White Tees";
        v2._length = 180;

        v2.comments.Add(commentsv2);


        v2.DisplayInfo();

        Comments commentsv3 = new Comments();
        commentsv3._commenterAuthor = "Maria";
        commentsv3._comment = "Amazing";
        video v3 = new video();
        v3._title = "The Biggest MYTH About Your Things";
        v3._author = "The Minimal Mom";
        v3._length = 884;

        v3.comments.Add(commentsv3);
        v3.DisplayInfo();

        List<video> VideoList = new List<video>();
        VideoList.Add(v1);
        VideoList.Add(v2);
        VideoList.Add(v3);

        foreach (video video in VideoList)
        {
            Console.WriteLine(video.DisplayInfo());
            foreach (Comments comment in video.comments)
            { 
                Console.WriteLine(comment.DisplayComment());
            }
        }


    }


}