using System;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// Class for message posting based around an author and text
    /// </summary>
    /// <author>
    /// Stefan Allen
    /// </author>>
    public class MessagePost : Post
    {
        public String Message { get; }

        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }
    }
}