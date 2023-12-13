namespace Subfolder_Selection_Project
{
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
