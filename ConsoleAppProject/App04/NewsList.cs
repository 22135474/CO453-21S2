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

        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }
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