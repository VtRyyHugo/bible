using System;
using System.Linq;
using System.IO;
using Bible.Entities.Exceptions;
namespace Entities
{
    class FileManager
    {
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
    }
}
