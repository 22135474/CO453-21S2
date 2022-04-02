using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NewsApp
    {

        private NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Social Posts");

            Console.ForegroundColor = ConsoleColor.White;

            string[] choices = new string[]
            {
                "Post Message",
                "Post Image",
                "Add Comment to Post",
                "Remove Post",
                "Like/Unlike Post",
                "Display Posts by Author",
                "Display All Posts",
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                Console.ForegroundColor = ConsoleColor.White;

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        PostImage();
                        break;
                    case 3:
                        AddComment();
                        break;
                    case 4:
                        RemovePost();
                        break;
                    case 5:
                        LikePosts();
                        break;
                    case 6:
                        DisplayByAuthor();
                        break;
                    case 7:
                        DisplayAll();
                        break;
                    case 8:
                        wantToQuit = true;
                        Console.WriteLine(" Console CLosed");
                        break;
                }
            }
            while (!wantToQuit);
        }

        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Like or Unlike a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            Console.WriteLine("Do you want to (like) or (unlike) the post? > ");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "like":
                    Console.WriteLine("Like a post\n");
                    news.LikePost(id);
                    break;
                case "unlike":
                    Console.WriteLine("Unlike a post\n");
                    news.UnlikePost(id);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try Again.");
                    LikePosts();
                    break;
            }

        }

        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Add a comment to a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            Console.WriteLine("Enter the comment you want to add > ");
            string comment = Console.ReadLine();
            news.AddPostComment(id, comment);
        }

        private void DisplayByAuthor()
        {
            Console.WriteLine("Enter the name of user you want to display > ");
            string author = Console.ReadLine();

            ConsoleHelper.OutputTitle($"Posts by {author}");
            news.DisplayAuthorPost(author);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            news.RemovePost(id);
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Photo");

            string author = InputName();

            Console.WriteLine("Please enter the file name > ");
            string filename = Console.ReadLine();

            Console.WriteLine("Please enter your message > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            Console.WriteLine($"\n You have just posted this photo: \n Name: {author} \n Caption: {caption}");
            post.Display();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting an message");

            string author = InputName();

            Console.WriteLine("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            Console.WriteLine($"\n You have just posted with the message: {message}");
            post.Display();

        }

        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}