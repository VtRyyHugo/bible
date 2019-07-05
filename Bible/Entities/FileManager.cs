using System.Linq;
using System.IO;
using Bible.Entities.Exceptions;

namespace Entities
{
    class FileManager
    {
        public static string[] ArrayText { get; private set; }
        private static string FilePath { get; set; }
        public static string BibleBookName { get; set; }
        public static string BibleChapterName { get; set; }

        public FileManager()
        {

        }

        public  static int FilesCounter(string tag)
        {
            int numberFiles = 0;
            if (Directory.Exists($@"Files\{tag}"))
            {
                numberFiles = Directory.GetFiles($@"Files\{tag}", "*", SearchOption.TopDirectoryOnly).Count();
            }
            else
            {
                throw new DomainException("Invalid folder path!");
            }
                 
            return numberFiles;
        }

        public static int CountVerses()
        {
            int count = 0;
            FilePath = $@"Files\{BibleBookName}\{BibleChapterName}.txt";
            if (File.Exists(FilePath))
            {
                TextReader tr = new StreamReader(FilePath);
                
                while (tr.ReadLine() != null)
                {
                    count++;
                }

                ArrayText = new string[count];
                tr.Close();

            }
            else
            {
                throw new DomainException("Invalid file path for count verses!");
            }

            return count;
        }

        private static void FillArrayText(string path)
        {
            if(File.Exists(path))
            {
                TextReader tr = new StreamReader(path);
                string line = "";
                int count = 0;

                while ((line = tr.ReadLine()) != null)
                {
                    ArrayText[count] = line;
                    count++;
                }

            }
            else
            {
                throw new DomainException("Invalid file path!");
            }
        }

        public static string GetBibleVerse(int index)
        {
            FillArrayText(FilePath);

            if ( ArrayText != null)
            {
                return ArrayText[index];
            }
            return "Empty text array!";  
        }
    }
}
