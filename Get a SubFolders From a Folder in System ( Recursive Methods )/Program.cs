namespace Get_a_SubFolders_From_a_Folder_in_System___Recursive_Methods__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of my Dotin folder:");
            foreach (var file in GetAllSubFolders.GetAllFiles("S:\\Dotin Bootcamp"))
            {
                Console.WriteLine(file);
            }

            //another way :

            //Console.WriteLine($"List of my Dotin folder: {string.Join(", ", GetAllSubFolders.GetAllFiles("S:\\Dotin Bootcamp"))}");
            //hamid testing
        }
    }
}
