using System;
using System.Collections;
using System.Linq;

namespace testGetCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные:");
            string data = Console.ReadLine();
            foreach (var item in IncriptMorze(data))
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static string[] IncriptMorze(string data)
        {
            char[] simbols = data.ToCharArray();
            int count = 0; //колличество неизветсных символов
            foreach (var simbol in simbols)
            {
                if (simbol == '?')
                    count++;
            }
            count = Convert.ToInt32(Math.Pow(count, 2));

            ArrayList list = new ArrayList();
            list.Add(data);
            if (data.Contains('?'))
            {
                //Список всех вариантов в list
                for (int i = 0; i < count; i++)
                {

                    char[] ch_array = list[i].ToString().ToCharArray();
                    for (int j = 0; j < ch_array.Length; j++)
                    {
                        if (ch_array[j] == '?')
                        {
                            ch_array[j] = '.';
                            list.Add(new string(ch_array));
                            ch_array[j] = '-';
                            list.Add(new string(ch_array));
                            break;
                        }
                    }
                }
                //чистим list от '?'
                for (int i = list.Count; i > 0; i--)

                {
                    if (list[i - 1].ToString().Contains('?'))
                    {
                        list.Remove(list[i - 1]);
                    }
                }
            }
            //подготовка массива бува
            string[] answer = (String[])list.ToArray(typeof(string));
            for (int i = 0; i < list.Count; i++)
            {
                switch (answer[i].ToString())
                {
                    case ".": answer[i] = "E "; break;
                    case "-": answer[i] = "T "; break;
                    case "..": answer[i] = "I "; break;
                    case ".-": answer[i] = "A "; break;
                    case "-.": answer[i] = "N "; break;
                    case "--": answer[i] = "M "; break;
                    case "...": answer[i] = "S "; break;
                    case "..-": answer[i] = "U "; break;
                    case ".-.": answer[i] = "R "; break;
                    case ".--": answer[i] = "W "; break;
                    case "---": answer[i] = "O "; break;
                    case "--.": answer[i] = "G "; break;
                    case "-.-": answer[i] = "K "; break;
                    case "-..": answer[i] = "D "; break;
                    case "....": answer[i] = "H "; break;
                    case "...-": answer[i] = "V "; break;
                    case "..-.": answer[i] = "F "; break;
                    case "..--": answer[i] = "Ü "; break;
                    case ".-..": answer[i] = "L "; break;
                    case ".-.-": answer[i] = "Ä "; break;
                    case ".--.": answer[i] = "P "; break;
                    case ".---": answer[i] = "J "; break;
                    case "---.": answer[i] = "Ö "; break;
                    case "----": answer[i] = "CH "; break;
                    case "--..": answer[i] = "Z "; break;
                    case "--.-": answer[i] = "Q "; break;
                    case "-.-.": answer[i] = "C "; break;
                    case "-.--": answer[i] = "Y "; break;
                    case "-...": answer[i] = "B "; break;
                    case "-..-": answer[i] = "X "; break;
                    default:
                        break;
                }
            }
            return answer;
        }
    }
}
