class main
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("You need to add folders/files like:  Freddy folder1 folder2 file1.txt file2.txt");
            return;
        }

        foreach (string s in args)
        {
            if (s.Contains('.'))
            {
                file(Directory.GetCurrentDirectory(), s);
            }
            else
            {
                folder(s);
            }
        }
    }

    private static void folder(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    private static void file(string path, string name)
    {
        string PathString = path + "/" + name;
        if (!File.Exists(PathString))
        {
            File.Create(PathString, 0);
        }
    }
}