using System;

namespace ConsoleAppProject.App04
{
    public class MessagePost : Post
    {
        public String Message { get; }

        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }
    }
}