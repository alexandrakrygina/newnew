using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class patient 
    {
        public string diagnosis { get; set; }
        public int talonchik { get; set; }
        public string name { get; set; }
        public string currentStatus { get; set; }
        public double temperature { get; set; }
        public string head { get; set; }
        public string anus { get; set; }
        public void KartochkaPatienta()
        {
            Console.WriteLine($"Имя: {name}, диагноз: {diagnosis}, текущий статус: {currentStatus}");
            return;
        }
        public void UchinitSkandal(doctor doctor)
        {
            if (doctor.experience < 10)
            {
                Console.WriteLine("Понабрали молодых, не знают ничего");

            }
           else if (doctor.price > 1500)
            {
                Console.WriteLine("Это не лечение, а обдираловка");
            }
        }
    }
}
