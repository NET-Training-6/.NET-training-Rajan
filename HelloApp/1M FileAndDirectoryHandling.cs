class FileAndDirectory
{
    string filename;
    string rootFolder = @"C:\Users\User\Desktop\C# training\.NET-training-Rajan\HelloApp\Text files";
    //@ symbols also called verbating character
    
    
    public void LearnFiles()
    {
        //Create a txtfile containing text "Hello World"
        string filePath = $"{rootFolder}\\test.txt";
        File.WriteAllText(filePath, "Hello World!");
        Console.WriteLine("File created successfully");

        string newDirPath = @$"{rootFolder}\\testFolder";
        Directory.CreateDirectory(newDirPath);

        //Create a folder with name "A" somewhere and create a text file a.file insid "A"
        string newDirName = @$"{rootFolder}\A";
        checkIfDirExists (newDirName);
        string newFilePath = @$"{newDirName}\a.file";
        File.WriteAllText(newDirName, "content inside a.file");

        //Create 10 folder with names folder1,folder2,folder3,folder4,folder5,folder6,folder7,folder8,folder9,folder10
        for(int i=1; i <=10; i++)
        {
           checkIfDirExists(@$"{rootFolder}\\Folder {i}");
        }

     }

     public void checkIfDirExists(string dirName)
     {
        if(Directory.Exists(dirName) == false)
        {
            Directory.CreateDirectory(dirName);
        }
     }

}