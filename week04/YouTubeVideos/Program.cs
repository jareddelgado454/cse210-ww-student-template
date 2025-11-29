using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video v1 = new Video("Cómo reparar una llanta", "TecnicoPro", 300);
        v1.AddComment(new Comment("Luis", "Muy buen tutorial!"));
        v1.AddComment(new Comment("Ana", "Me ayudó bastante."));
        v1.AddComment(new Comment("Carlos", "Gracias por la explicación."));
        videos.Add(v1);


        Video v2 = new Video("Aprende C# en 10 minutos", "CodeMaster", 600);
        v2.AddComment(new Comment("Pedro", "Muy claro el contenido."));
        v2.AddComment(new Comment("Julia", "Explicas mejor que mi profesor."));
        v2.AddComment(new Comment("Marco", "¡Excelente video!"));
        videos.Add(v2);

        Video v3 = new Video("Cómo cocinar pasta perfecta", "ChefLima", 450);
        v3.AddComment(new Comment("Rosa", "Quedó deliciosa, gracias!"));
        v3.AddComment(new Comment("Pablo", "Lo haré hoy mismo."));
        v3.AddComment(new Comment("Eliana", "Muy fácil de seguir."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");

            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
