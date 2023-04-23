using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class nevrolog : doctor
    {
        public void Zakluchenie(patient patient)
        {

            if (patient.head == "нет жалоб")
            {
                patient.currentStatus = "здоров";
                Console.WriteLine("Невролог считает, что пациент здоров");
            }
            else
            {
                patient.currentStatus = "болен";
                Console.WriteLine("Невролог считает, что пациент болен");
            }

        }

        public override void PozvatVKabinet(patient patient)
        {
            if (patient.talonchik == 1)
            {
                Console.WriteLine($"Проходите, {patient.name}");
            }
            else
            {
                Console.WriteLine("женщина, у нас очередь");
            }
        }


    }
}
