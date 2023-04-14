using System.IO.Compression;

public class FileManager
{
    Exception noPathException = new Exception("Путь не указан");


    public string Unpack(string? path, string? destinationPath = null) 
    {
        if (destinationPath == null) destinationPath = Directory.GetCurrentDirectory();
        if (path == null) throw (noPathException);


        if (path.Contains(".zip"))
        {
            try
            {
                ZipFile.ExtractToDirectory(path, destinationPath);
                return "Архив распакован";
            }

            catch
            {
                throw (new Exception($"Невозможно распаковать архив {path}"));

            }
        }
        else
        {
            throw (new Exception("Формат архива не поддерживается или путь указан неверно"));
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

    public void WriteToFile(string path, string data)
    {
        if (path == null) throw (noPathException);

        if (File.Exists(path)) File.WriteAllText(path, data);

        else throw (new Exception($"Запись в несуществующий файл {path}"));
    }

    public void Delete(string? path)
    {
        if (path == null) throw (noPathException);

        if (File.Exists(path)) File.Delete(path);

        else throw (new Exception($"Удаление несуществущего файла {path}"));
    }

}