using System;
using System.Text;

namespace meth2
{
    class Program
    {
        static string lowtext(string text)
        {
            StringBuilder adde = new StringBuilder();
            string[] mastext = text.Split(' ');
            for (int i=0;i<mastext.Length;i++)
            {
                char [] masymbs = mastext[i].ToCharArray();
                for (int j = 0; j < masymbs.Length; j++)
                {
                    char symb = masymbs[j];
                    if (char.IsLower(symb))
                    {
                        string usymb = Convert.ToString(char.ToUpper(symb));
                        adde.Append(usymb);
                    }
                    else adde.Append(symb);
                }
                adde.Append(' ');
            }
            text = adde.ToString();
            
            return text;
        }
        static string bigtext(string text)
        {
            StringBuilder adde = new StringBuilder();
            string[] mastext = text.Split(' ');
            for (int i = 0; i < mastext.Length; i++)
            {
                char[] masymbs = mastext[i].ToCharArray();
                for (int j = 0; j < masymbs.Length; j++)
                {
                    char symb = masymbs[j];

                    
                    if (char.IsLower(symb))
                    {
                        string usymb = Convert.ToString(char.ToUpper(symb));

                        adde.Append(usymb);
                    }
                    else adde.Append(symb);
                }
                adde.Append(' ');
            }
            text = adde.ToString();

            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string vvod = Console.ReadLine();
            Console.WriteLine("Что сделать с текстом:");
            Console.WriteLine("1)Увеличить");
            Console.WriteLine("2)Уменьшить");
            string ch = Console.ReadLine();
            string vivod = null;
            if (ch== "1" || ch=="1)" || ch=="один")
            {
                
                vivod = bigtext(vvod);
            }
            else if (ch =="2" || ch== "2)" || ch=="два") vivod = lowtext(vvod);
            else Console.WriteLine(" иди нахуй");
            Console.WriteLine(vivod);
        }
    }
}
