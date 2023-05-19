using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Методы расширения (extension methods) позволяют добавлять новые методы в уже существующие типы без создания нового производного класса. Эта функциональность бывает особенно полезна, когда нам хочется добавить в некоторый тип новый метод, но сам тип (класс или структуру) мы изменить не можем, поскольку у нас нет доступа к исходному коду. Либо если мы не можем использовать стандартный механизм наследования, например, если классы определенны с модификатором sealed.

namespace Lesson19._05
{ 

public static class StringExtension
{
    public static int CharCount(this string str, char c) // показывает к какому типу данных применяется
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }

        public static char Cezar(this char ch)
        {
            ch = (char)(ch + 3);
            return ch;
        }
    }
internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = (int)'A'; i <= (int)'Z'; i++)
            //{
            //    Console.Write($"{(char)i} код {i} " +
            //        $"{(char)(i %26 + 3)} код {i %26 + 3}\n");   
            //}
            Console.WriteLine("*******");
        string text = "Добрый день! ооо";
        char symb = 'о';
        Console.WriteLine($"В {text} " +
            $"символ {symb} " +
            $"встречается {text.CharCount(symb)} раз");
            char temp;
            string text02 = "";
            for (int i =0; i < text.Length; i ++)
            {
                temp = text[i].Cezar();
                text02 += temp;
            }
            Console.WriteLine($"{text} = {text02} ");
            
        Console.ReadKey();
    }
    }
}
