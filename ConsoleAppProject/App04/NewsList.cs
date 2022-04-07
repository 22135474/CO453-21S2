using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    public class NewsFeed
    {
        public const string AUTHOR1 = "Stefan";
        public const string AUTHOR2 = "Bob";

        private readonly List<Post> posts;

        /// <summary>
        /// Allows to set defult message that are already in the app when ran
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR1, "Prototype");
            AddMessagePost(post);
            post.AddComment("New post!");

            PhotoPost photoPost = new PhotoPost(AUTHOR2, "Prototype.jpg", "Prototype");
            AddPhotoPost(photoPost);
        }

        public Post Post
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Adds a message to the post 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        /// <summary>
        /// Adds a photo to the post 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// Allows find by user to work
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void DisplayAuthorPost(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Adds the time to the users post 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void FindDate(string date)
        {
            foreach (Post post in posts)
            {
                if (post.Timestamp.ToLongDateString().Contains(date))
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Adds a comment to the post and displays error if wrong
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void AddPostComment(int id, string text)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nThe comment have been added to post {id}!\n");
                post.AddComment(text);
                post.Display();
            }
        }

        /// <summary>
        /// Adds a like to the post and displays error if wrong
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void LikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have liked the the post {id}!\n");
                post.Like();
                post.Display();
            }
        }

        /// <summary>
        /// Adds a dislike to the post and displays error if wrong
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void UnlikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have unliked the the post {id}!\n");
                post.Unlike();
                post.Display();
            }
        }

        /// <summary>
        /// Allows the user to remove a post 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($" \nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($" \nThe following Post {id} has been removed!\n");

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// allows user to find a post 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// Allows user to display all posts 
        /// </summary>
        /// <author>
        /// Stefan Allen
        /// </author>>
        public void Display()
        {
            ConsoleHelper.OutputTitle("Display All Posts");

            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine(); 
            }
        }
    }

}