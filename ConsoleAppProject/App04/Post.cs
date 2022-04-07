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

        /// <summary>
        /// Sets the defults for post 
        /// like, comments and username
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public Post(String author)
        {
            instances++;
            PostId = instances;

            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Adds a like
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void Like()
        {
            likes++;
        }

        /// <summary>
        /// Adds a dislike
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        /// <summary>
        /// Adds a comment
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        /// <summary>
        /// Adds a displays the posts information
        /// id, username and time.
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
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
            /// <summary>
            /// If it has more then 0 likes show ammout
            /// </summary>
            if (likes > 0)
            {
                Console.WriteLine($"    Likes: -  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }
            /// <summary>
            /// If it has 0 likes shows no comments
            /// </summary>
            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                /// <summary>
                /// Allows the user to expand the comments 
                /// </summary>
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

        /// <summary>
        /// Gets how many post there are 
        /// </summary>
        public static int GetNumberOfPosts()
        {
            return instances;
        }

        /// <summary>
        /// Shows the time stamp for the post 
        /// </summary>
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