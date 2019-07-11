using System.Linq;
using System.IO;
using Bible.Entities.Exceptions;
using Bible.Entities.UserControls;

namespace Entities
{
    class FileManager
    {
        public static string[] ArrayText { get; private set; }
        private static string FilePath { get; set; }
        public static string BibleBookName { get; set; }
        public static string BibleBookNameUTF8;
        public static string BibleChapterName { get; set; }
        public static string BibleChapterNumber { get; set; }
        public static int BibleVerseNumber { get; set; }
        private static  int VersesQuantity;

        public FileManager()
        {

        }

        public static int FilesCounter(string tag)
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
                VersesQuantity = count;
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
            if (File.Exists(path))
            {
                TextReader tr = new StreamReader(path);
                string line = "";
                int count = 0;

                while ((line = tr.ReadLine()) != null)
                {
                    if (VersesQuantity < 100)
                    {
                        ArrayText[count] = line.Substring(2).TrimStart();
                        count++;
                    }
                    else
                    {
                        ArrayText[count] = line.Substring(3).TrimStart();
                        count++;
                    } 
                }

            }
            else
            {
                throw new DomainException("Invalid file path!");
            }
        }

        public  string GetBibleVerse(int index)
        {
            FillArrayText(FilePath);

            if (index >= ArrayText.Length -1)
            {
                UCBibleText.NextText = false;
                UCBibleText.PreviousText = true;
                return ArrayText[ArrayText.Length - 1];
            }
            else if (index <= 0)
            {
                UCBibleText.PreviousText = false;
                UCBibleText.NextText = true;
                return ArrayText[0];
            }

            if (ArrayText != null)
            {
                UCBibleText.NextText = true;
                UCBibleText.PreviousText = true;
                return ArrayText[index];
            }

            return "";
        }

    }
}
