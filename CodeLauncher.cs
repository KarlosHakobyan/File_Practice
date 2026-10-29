using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class CodeLauncher
    {
        public static void Launch()
        {
            string path = "text.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                Console.WriteLine("File already created.");
            }

            Console.WriteLine(File.Exists(path));

            File.WriteAllText(path, "Hello my C# friends!");
            File.AppendAllText(path, "\nLearning File class");

            string content = File.ReadAllText(path);

            Console.WriteLine(content);
            Console.WriteLine($"Characters: {content.Length}");


            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


            File.WriteAllText("text.txt", "Hello C#!");

            File.AppendAllText("text.txt", "\nLearning File class");

            Console.WriteLine(File.ReadAllText("text.txt"));


            Console.WriteLine($"Attributes: {File.GetAttributes(path)}");
            Console.WriteLine($"Creation Time: {File.GetCreationTime(path)}");
            Console.WriteLine($"Creation Time (UTC): {File.GetCreationTimeUtc(path)}");
            Console.WriteLine($"Last Access Time: {File.GetLastAccessTime(path)}");
            Console.WriteLine($"Last Write Time: {File.GetLastWriteTime(path)}");
            Console.WriteLine($"Last Write Time (UTC): {File.GetLastWriteTimeUtc(path)}");

            FileInfo file = new("text.txt");

            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"Extension: {file.Extension}");
            Console.WriteLine($"Full path: {file.FullName}");
            Console.WriteLine($"Size: {file.Length} bytes");
            Console.WriteLine($"Exists: {file.Exists}");
            Console.WriteLine($"Created: {file.CreationTime}");
            Console.WriteLine($"Last modified: {file.LastWriteTime}");

            File.Copy(path, "copy.txt", true);
            File.Move("copy.txt", "renamed.txt");
            File.Delete("renamed.txt");
            Console.WriteLine("Renamed File deleted.");
        }
    }
}
