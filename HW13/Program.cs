//Task 1
/*string? a;
Console.WriteLine("Input string");
a = Console.ReadLine();
var folder = new DirectoryInfo(a);
DirectoryInfo[] subFolders = folder.GetDirectories();
foreach (DirectoryInfo subFolder in subFolders)
{
    FileInfo[] subFules = subFolder.GetFiles();
    foreach (FileInfo subFule in subFules)
    {
        if (subFule.Name.Substring(subFule.Name.Length-4) == ".txt")//поменять на txt - exe 
        {
            foreach (FileInfo subFile in subFules)
            {
                subFile.Delete();
            }
            subFolder.Delete();
        }
    }
}*/
//Task 2
string? a;
Console.WriteLine("Input string");
a = Console.ReadLine();

string[] subFiles = Directory.GetFiles(a);
int count = 0;
foreach (string subFile in subFiles)
{
    string fileName = Path.GetFileNameWithoutExtension(subFile);
    bool isDigit = true;
    foreach (char symbol in fileName)
    {
        if (!Char.IsDigit(symbol))
        {
            isDigit = false;
            break;
        }
    }

    if (isDigit)
    {
        count++;
    }
}
Console.WriteLine(count);