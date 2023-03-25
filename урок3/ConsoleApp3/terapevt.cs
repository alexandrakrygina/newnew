using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class terapevt : doctor
    {

    
        public void Zakluchenie(patient patient)
        {
            
            if (patient.temperature > 37)
            {
                patient.currentStatus = "Болен";
                Console.WriteLine("Терапевт считает, что пациент болен");
            }
            else
            {
                patient.currentStatus = "Здоров";
                Console.WriteLine("Терапевт считает, что пациент здоров");
            }

        }


    }
}
