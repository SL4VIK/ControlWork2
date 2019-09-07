using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork2
{
    public abstract class File
    {
        
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
        public virtual void Parce(string input)
        {
            string[] splitInput = input.Split(new char[] { '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string nameWithExt = splitInput[0];
            Size = splitInput[1];
        }

    }
    public class TextFile : File
    {
        public string Content { get; set; }
        public string Count { get; set; }
        public TextFiles(string[] strarr) : base(strarr)
        {
            string[] filecontent = strarr[4].Split(';');
            Content = strarr[4];

        }

    }
    public class ImageFile : File
    {
        public string Content { get; set; }
        public static int Count { get; set; }
        public ImageFiles(string[] strarr) : base(strarr)
        {
            string[] filecontent = strarr[4].Split(';');
            Content = strarr[4];

        }
    }
    public class VideoFile : Files
    {
        public string Length { get; set; }
        public string Resolution
        {
            get: set; }
        }
    }
}
