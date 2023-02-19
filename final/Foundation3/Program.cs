using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Mistake class", 
        "In this class you will learn how to recognize a mistake on oyur programm", 
        "23/01/2023", "09:00", "street 43", "Lecture", 
        "In this class you will learn how to recognize a mistake on oyur programm", "Teacher Who", 10);
        Console.WriteLine(lecture.DisplayLectureEventS());
        Console.WriteLine(lecture.DisplayLectureEventF());
        Console.WriteLine(lecture.DisplayLectureEventSh());

    }
}