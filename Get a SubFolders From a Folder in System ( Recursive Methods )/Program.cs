namespace Get_a_SubFolders_From_a_Folder_in_System___Recursive_Methods__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public static class GetAllSubFolders
    {
        public static List<string> GetAllFiles(string path)
        {
            List<string> resault = new List<string>();
            foreach (var file in Directory.GetFiles(path))
            {
                resault.Add(file);
            }

            foreach (var directory in Directory.GetDirectories(path))
            {
                resault.AddRange(GetAllFiles(directory));

            }
            return resault;
        }
    }
}
