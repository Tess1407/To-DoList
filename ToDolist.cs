using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    internal class ToDolist
    {
        private List<ToDopolozky> polozky;

        public ToDolist()
        {
            polozky = new List<ToDopolozky>();
        }
        public void PridatPolozku(string nazev)
        {
            var novaPolozka = new ToDopolozky { Nazev = nazev, JeHotovo = false };
            polozky.Add(novaPolozka);
            Console.WriteLine("Položka přidána: ", nazev);
        }
        public void Oznacit(int index)
        {
            if (index >= 0 && index < polozky.Count)
            {
                polozky[index].JeHotovo = true;
                Console.WriteLine("Úkol označen jako hotový: " + polozky[index].Nazev);
            }
            else
            {
                Console.WriteLine("Neplatné");
            }
        }
        public void VypisUkoly()
        {
            Console.WriteLine("To-Do List:");
            for (int i = 0; i < polozky.Count; i++)
            {
                string status = polozky[i].JeHotovo ? "[x]" : "[ ]";
                Console.WriteLine(status + " " + polozky[i].Nazev);
            }
        }
    }
}
