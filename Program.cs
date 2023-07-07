// See https://aka.ms/new-console-template for more information
using todolist;

var toDoList = new ToDolist();
Console.WriteLine("Vítej v To-Do seznamu");
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Vyber akci");
    Console.WriteLine("1 - Přidat úkol");
    Console.WriteLine("2 - Označit jako hotové");
    Console.WriteLine("3 - Vypsat úkoly");
    Console.WriteLine("4 - Zavřít aplikaci");
    string vstup = Console.ReadLine();
    switch (vstup)
    {
        case "1":
            Console.WriteLine("Vložte název úkolu");
            string nazev = Console.ReadLine();
            toDoList.PridatPolozku(nazev);
        break;
        case "2":
            Console.WriteLine("Vložte index úkolu");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                toDoList.Oznacit(index);
            }
            else
            {
                Console.WriteLine("Neplatný index");
            }
        break;
        case "3":
            toDoList.VypisUkoly();
        break;
        case "4":
            Console.WriteLine("Nashledanou");
            return;
        default:
            Console.WriteLine("Neplatná akce");
        break;
    }
}