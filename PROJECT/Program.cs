//using System;

//class Program
//{
    //static void SelectRace()
    //{
       // string[] namesRace = { "Люди", "Эльфы", "Гномы", "Орки" };
        //for (int i = 0; i < namesRace.Length - 1; i++)
        //{
           // Console.Write(i + 1 + " - " + namesRace[i] + ", ");
        //}
    //Console.Write(namesRace.Length + "-" + namesRace[namesRace.Length-1] +".");
   // }
   // static void Main(string[] args)
    //{
      //  SelectRace();
   // }
//}

using System;

class Program
{
    static void WriteSelect (string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length-1] + ".");
    }
    static void SelectRase()
    {
        string[] namesRase = {"Люди", "Эльфы", "Гномы", "Орки"};
        WriteSelect(namesRase);
        Console.Write("Укажите вашу расу: ");
        int indexRase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesRase[indexRase-1]);
    }
    static void SelectClass()
    {
        string[] namesClass = {"Воин", "Маг", "Разбойник", "Вор"};
        WriteSelect(namesClass);
        Console.Write("Укажите вашу класс: ");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс " + namesClass[indexClass-1]);
    }
    static void SelectPol()
    {
        string[] namesPol = {"Мужчина", "Женщина"};
        WriteSelect(namesPol);
        Console.Write("Укажите ваш пол: ");
        int indexPol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол " + namesPol[indexPol-1]);
    }
    static void Main (string [] args)
    {
        // int[] numbers = new int[4];
        // int[] numb = {1,4,5,4};
        SelectRase();
        SelectClass();
        SelectPol();
    }
}