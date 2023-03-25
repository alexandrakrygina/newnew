using ConsoleApp3;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Xml.Linq;

public static class program
{
    public static void Main(string[] args)
    {
        nevrolog ivanov = new()
        {
            professionality = "невролог",
            name = "Иван Иванович",
            experience = 20,
            price = 1800
        };
        

        proctolog petrova = new()
        {
            professionality = "проктолог",
            name = "Арина Петровна",
            experience = 5,
            price = 1000
        };
       
    
        terapevt house = new()
        {
            professionality = "терапевт",
            name =  "Грегори Хаус",
            experience = 25,
            price = 100500
   
        };
      

        patient babushka = new()
        {
            name = "Антонина",
            diagnosis = "Альцгеймер",
            talonchik = 1,
            currentStatus = "на больничном",
            temperature = 38.1,
            head = "Болит голова",
            anus = "нет жалоб"
        };
       
       
        patient women = new ()
        {
            name = "Ирина",
            diagnosis = "геморрой",
            talonchik = 3,
            currentStatus = "на больничном",
            temperature = 36.6,
            head = "нет жалоб",
            anus = "Кровянистые выделения"
        };

        
    }
  
    

}
