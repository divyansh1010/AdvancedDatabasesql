using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Week9
{
    class Program
    {

        static void Example1()
        {

            string cwd = Environment.CurrentDirectory;

            char dir_sep = Path.DirectorySeparatorChar;

            char[] invalid = Path.GetInvalidPathChars();

            Console.WriteLine(cwd);

            Console.WriteLine("The directory separtor is " + dir_sep);

            foreach (char c in invalid)
            {

                Console.WriteLine("The character {0} has an ASCII value of {1}", c, (int)c);

            }

        }

        static void Example2()
        {

            string folderName = Environment.SpecialFolder.UserProfile.ToString();

            Console.WriteLine(folderName);

            string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            Console.WriteLine(fullPath);

        }

        static void Example3()
        {

            string cwd = Environment.CurrentDirectory;

            Console.WriteLine(cwd);
            //C: \Users\Benny Boom\source\repos\ConsoleApp1_032218\ConsoleApp1_032218\bin\Debug

            //          //  C: \Users\Benny Boom\source\repos\ConsoleApp1_032218

            string upThreeParents = cwd + Path.DirectorySeparatorChar
                + ".." + Path.DirectorySeparatorChar + ".."
                + Path.DirectorySeparatorChar + "..";

            Console.WriteLine(upThreeParents);

            string[] dirs = Directory.GetDirectories(upThreeParents);

            Console.WriteLine("Looping Through Directories");


            foreach (string fullPath in dirs)
            {

                Console.WriteLine(fullPath);
            }

        }

        static void Example4()
        {

            string fileName = "silence.txt";
            string content = "Hello from Program.cs!";

            string newLine = "\n";



            content += Environment.NewLine;

            File.AppendAllText(fileName, content);

        }

        static void Example5()
        {

            /*
 *
 *
 * Ask the user for a filename
 * Ask the user for some content
 * Save the content in the current directory
 * Save the content in the parent directory of the current directory
 *      Save it as the filename specified in the first step
 * 
 */
            string filename, content, directoryPath, parentDirectoryPath;

            Console.WriteLine("Please enter a file name");

            filename = Console.ReadLine();
            filename += ".txt";
            Console.WriteLine("Please enter some content");


            content = Console.ReadLine();

            content += Environment.NewLine;

            File.AppendAllText(filename, content);

            parentDirectoryPath = Environment.CurrentDirectory
                + Path.DirectorySeparatorChar + ".."
                + Path.DirectorySeparatorChar;


            directoryPath = ".."
                + Path.DirectorySeparatorChar;

            File.AppendAllText(parentDirectoryPath + filename, content);
            File.AppendAllText(directoryPath + filename + "1", content);

        }

        static void Example6()
        {

            string fileName = "tired.txt";

            FileStream fs = new FileStream(fileName, FileMode.Append);

            long fileSize = fs.Length;

            if (fileSize == 0)
            {

                Console.WriteLine("The file does not exists or is empty!");


            }
            else
            {

                Console.WriteLine("The file exists!");

                //  byte value = 65;
                //  fs.WriteByte(value);

                Console.WriteLine("Enter a value to add to the file!");

                string content = Console.ReadLine();

                foreach (char a in content)
                {

                    fs.WriteByte((byte)a);

                }


            }


            fs.Close();

        }

        static void Example7()
        {

            string fileName = "tired.txt";
            FileStream fs = new FileStream(fileName, FileMode.Open);

            long position = 12;

            position = fs.Length / 2;

            fs.Seek(position, SeekOrigin.Begin);

            StreamReader sr;

            using (sr = new StreamReader(fs))
            {

                Console.WriteLine(sr.ReadToEnd());

            }

            fs.Close();

            using (FileStream fs1 = new FileStream("tired.txt", FileMode.Append))
            {


            }

        }

        static void Example8()
        {

            string fileName = "tired.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {

                string content = "Put this content inside";

                sw.WriteLine(content);

            }


        }

        static void Example9()
        {

            FileInfo myfile = new FileInfo("tired.txt");

            Console.WriteLine("Ext = {0}, name = {1}", myfile.Extension, myfile.Name);

            using (StreamWriter sw = myfile.CreateText())
            {

                string content = Environment.NewLine + "Let us add this to the file";


                sw.WriteLine(content);


            }

        }

        static void Example10()
        {

            DateTime dt = new DateTime();
            Guid.NewGuid();
            DirectoryInfo myDir = new DirectoryInfo("NewFolderC#");

            // myDir.Create();

            //myDir.CreateSubdirectory("FolderOfMyFolder");

            myDir.Delete(true);
        }

        static void Main(string[] args)
        {
            Example3();
            Console.ReadKey();

        }
    }
}
