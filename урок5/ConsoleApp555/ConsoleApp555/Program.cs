class Program2
{
    public static List<(string name, DateTime creationTime, string type)> Parse(string str)
    {
        string[] piu = str.Split("\t");
        var result = new List<(string name, DateTime creationTime, string type)>();

        for (int i = 0; i < piu.Length - 1; i += 3)
        {
            result.Add((piu[i], Convert.ToDateTime(piu[i + 1]), piu[i + 2]));
        }

        for (int i = 0; i < result.Count; ++i) 
        {
            for (int j = 0; j < result.Count; ++j)
            {
                if (result[i].Item2 > result[j].Item2)
                {
                    (result[i], result[j]) = (result[j], result[i]);
                }
            }
        }

        return result;
    }

    public static void Main()
    {

        try
        {
            var appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var pathToFileWithPath = $"{appdataPath}/ggg.txt";
            var currentFM = new FileManager();

            Console.WriteLine("Читаю файл с путем");
            string pathToCSV = currentFM.Read(pathToFileWithPath);

            Console.WriteLine("Читаю файл со списком");
            string filesListRaw = currentFM.Read(pathToCSV);
            var filesList = Parse(filesListRaw);
            foreach (var element in filesList) Console.WriteLine(element);


        }

        catch (Exception ex) 
        {
            Console.WriteLine("Произошла ошибка");
            Console.WriteLine(ex.Message);
        }

    }
}