using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
        class proctolog : doctor
        {
            public void Zakluchenie(patient patient)
            {

                if (patient.anus == "нет жалоб")
                {
                    patient.currentStatus = "здоров";
                    Console.WriteLine("Проктолог считает, что пациент здоров");
                }
                else
                {
                    patient.currentStatus = "болен";
                    Console.WriteLine("Проктолог считает, что пациент болен");
                }

            }
        public override void PozvatVKabinet(patient patient)
        {
            if (patient.talonchik == 1)
            {
                Console.WriteLine($"Чего стоим, {patient.name}, не задерживайте очередь");
            }
            else
            {
                Console.WriteLine("я вас не приму просто");
            }
        }


    }
   
}
