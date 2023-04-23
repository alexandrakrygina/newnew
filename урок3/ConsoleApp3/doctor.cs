using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    abstract class doctor
    {
        public string professionality { get; set; }
        public string name { get; set; }
        public int experience { get; set; }
        public int price { get; set; }
         public virtual void PozvatVKabinet(patient patient)
        {           
            if (patient.talonchik == 1)
            {
                Console.WriteLine($"Заходите, {patient.name}");
            }
            else 
            {
                Console.WriteLine("Ну куда вы лезете без очереди");
            }    
         }
        public void dosyevracha()
        {
            Console.WriteLine($"Имя: {name}, специальность: {professionality}, стаж работы {experience} лет, стоимость приема: {price} руб.");
            return;
        }
    }
   
  
   
}
