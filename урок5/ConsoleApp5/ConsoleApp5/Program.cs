

class Program1
{

  
    public static void Main()
    {
        try
        {

            string currentPath;
            var currentFM = new FileManager();

            var archivePath = "зип.zip";
            currentFM.Unpack(archivePath);

           
            currentPath = "зип";
            var info = (currentFM.Observe(currentPath));
            foreach (var element in info) Console.WriteLine(element);

       
            var filename = "about.csv";
            var pathToFile = currentFM.MakeFile(filename);
          }

        catch (Exception ex) 
        {
            Console.WriteLine("Произошла некая ошибка");
            Console.WriteLine(ex.Message);
        }

    }
}