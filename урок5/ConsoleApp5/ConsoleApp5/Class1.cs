using System.IO.Compression;

public class FileManager
{
    Exception noPathException = new Exception("Не указан путь");


    public string Unpack(string path, string destinationPath = null) 
    {
        if (destinationPath == null) destinationPath = Directory.GetCurrentDirectory();
        if (path == null) throw (noPathException);

           else
        {
            throw (new Exception("Путь указан неверно или архива не существует"));
        }
    }

    public string Read(string path)
    {
        if (path == null) throw (noPathException);

        if (File.Exists(path)) return File.ReadAllText(path);

        else throw (new Exception($"Невозможно прочитать данные из файла {path}"));
    }

    public string[] Observe(string path)
    {
        if (path == null) throw (noPathException);

        try
        {
            List<string> result = new List<string>();

            string[] dirList = Directory.GetDirectories(path);
            for (int i = 0; i < dirList.Length; ++i)
            {
                dirList[i] += "\t" + Directory.GetLastWriteTime(dirList[i]);
                dirList[i] += "\tПапка";
            }
            result.AddRange(dirList);

            string[] filesList = Directory.GetFiles(path);
            for (int i = 0; i < filesList.Length; ++i)
            {
                filesList[i] += "\t" + File.GetLastWriteTime(filesList[i]);
                filesList[i] += "\tФайл";
            }
            result.AddRange(filesList);


            return result.ToArray();
        }

        catch
        {
            throw (new Exception($"Невозможно посмотреть содержимое {path}"));
        }
    }

    public string MakeFile(string path)
    {
        if (path == null) throw (noPathException);

        try
        {
            var currentFile = File.Create(path);
            currentFile.Close();
            return Path.GetFullPath(path);
        }

        catch
        {
            throw (new Exception($"Невозможно создать файл {path}"));
        }
    }

}