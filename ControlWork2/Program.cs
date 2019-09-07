using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace ControlWork2{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Text:file.txt(6B);Some string content							Image:img.bmp(19MB);1920х1080							Text:data.txt(12B);Another string							Text:data1.txt(7B);Yet another string							Movie:logan.2017.mkv(19GB);1920х1080;2h12m";

            List<File> result = new List<File>();
            string[] files = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < files.Length; i++)
            {
                string[] split = files[i].Split(':');
                string fileType = files[i].Split(':')[0].ToLower();
                File newFile = null;
                switch (fileType)
                {
                    case "text":
                        //string[] splitFileInfo = split[1].Split(new char[] { '(',')', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        TextFile textFile = new TextFile();
                        textFile.Parce(split[1]);
                        result.Add(textFile);
                        break;
                    case "image":
                        ImageFile imageFile = new ImageFile();
                        imageFile.Parce(split[1]);
                        result.Add(imageFile);
                        break;
                    case "movie":
                        VideoFile movieFile = new VideoFile();
                        movieFile.Parce(split[1]);
                        result.Add(movieFile);
                        break;
                    default:
                        break;
                }
            }
        }
    }}}