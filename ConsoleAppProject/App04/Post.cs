using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{   
    public class Post
    {
        public int PostId { get; }
        public String Username { get; set; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        private int likes;

        private readonly List<String> comments;

        public Post(String author)
        {
            instances++;
            PostId = instances;

            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        public void Like()
        {
            likes++;
        }

        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        public void AddComment(String text)
        {
            comments.Add(text);
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\tPost ID:\t {PostId}");
            Console.WriteLine($"\tAuthor:\t\t {Username}");
            Console.WriteLine($"\tTime Elpased:\t {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"\tDate Posted:\t {Timestamp.ToLongDateString()}");
            Console.WriteLine($"\tTime Posted:\t {Timestamp.ToLongTimeString()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes: -  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($"    Comment(s): {comments.Count}  Click here to view.");
                foreach (string comments in comments)
                {
                    Console.WriteLine($"\tComment: {comments}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("===================================================");
                    Console.ForegroundColor = ConsoleColor.White;

                }


            }
        }

        public static int GetNumberOfPosts()
        {
            return instances;
        }
 
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

    }


}