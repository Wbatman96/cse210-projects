using System;

class Program
{
    static void Main(string[] args)
    {
        Video puzzle = new Video("1000 Piece Puzzle", "ThePuzzler", 1538);
        Comment comment1 = new Comment("Joe", "That looks difficult.");
        Comment comment2 = new Comment("Bob", "I could never do that!");
        Comment comment3 = new Comment("Kevin", "Well done.");

        puzzle.AddComment(comment1);
        puzzle.AddComment(comment2);
        puzzle.AddComment(comment3);

        Video puzzle2 = new Video("1500 Piece Puzzle", "ThePuzzler", 1843);
        Comment comment4 = new Comment("Sara", "That must have taken a long time.");
        Comment comment5 = new Comment("Zack", "Gnarly stuff dude.");
        Comment comment6 = new Comment("John", "That looks cool.");

        puzzle2.AddComment(comment4);
        puzzle2.AddComment(comment5);
        puzzle2.AddComment(comment6);

        Video puzzle3 = new Video("2000 Piece Puzzle", "ThePuzzler", 2486);
        Comment comment7 = new Comment("Bob", "That one is huge!");
        Comment comment8 = new Comment("Kevin", "I don't know how you can do one that large.");
        Comment comment9 = new Comment("Zack", "I did that puzzle too.");

        puzzle3.AddComment(comment7);
        puzzle3.AddComment(comment8);
        puzzle3.AddComment(comment9);

        puzzle.Display();
        puzzle.ShowComments();
        Console.WriteLine();
        puzzle2.Display();
        puzzle2.ShowComments();
        Console.WriteLine();
        puzzle3.Display();
        puzzle3.ShowComments();
    }
}