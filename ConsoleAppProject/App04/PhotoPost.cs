using System;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// Class for photo posting based around an file name, caption and author
    /// </summary>
    /// <author>
    /// Stefan Allen
    /// </author>>
    public class PhotoPost : Post
    {
        public String Filename { get; set; }

        public String Caption { get; set; }

        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }
    }
}