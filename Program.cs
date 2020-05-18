using System;
using System.Xml.Serialization;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            


            // 2
            // SumInWords(9401);
            // 3
            // SplitJoin("Класс string не разрешает изменять существующие объекты");
            // 4-5
            // ExampleStringBuilder();
            //6 
            CharArray();
        }
        public static void SumInWords(int param)
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder(200);

            int first = param / 1000 - 1;
            int second = param / 100 % 10 - 1;
            int third = param / 10 % 10 - 1;
            int fourth = param % 10 - 1;
            int last = param % 100;

            Console.WriteLine("1: {0}, 2: {1}, 3: {2}, 4: {3}, last:{4}", first, second, third, fourth, last);

            string[] ar1 = {"один ", "два ",
                            "три", "четыре", "пять",
                            "шесть", "семь", "восемь",
                            "девять"};
            string[] ar2 = {"десять", "двадцать",
                            "тридцать", "сорок", "пятьдесят",
                            "шестьдесят", "семьдесят", "восемьдесят",
                            "девяносто"};
            string[] ar3 = {"сто", "двести",
                            "триста", "четыреста", "пятьсот",
                            "шестьсот", "семьсот", "восемьсот",
                            "девятьсот"};
            string[] ar4 = {"одна тысяча", "две тысячи",
                            "три тысячи", "четыре тысячи", "пять тысяч",
                            "шесть тысяч", "семь тысяч", "восемь тысяч",
                            "девять тысяч"};
            string[] ar5 = {"одиннадцать", "двенадцать",
                            "тринадцать", "четырнадцать", "пятнадцать",
                            "шестнадцать", "семнадцать", "восемнадцать",
                            "девятнадцать"};
            if (last > 10 && last < 20)
            {
                ar2 = ar5;
                third = last % 10 - 1;
                fourth = -1;
            }

            string res = temp.ToString();

            if (first >= 0) { res = ar4[first] + ' '; }
            if (second >= 0) { res += ar3[second] + ' '; }
            if (third >= 0) { res += ar2[third] + ' '; }
            if (fourth >= 0)
            {
                res += ar1[fourth] + ' ';
                switch (fourth)
                {
                    case 0:
                        res += "рубль";
                        break;
                    case 1:
                        res += "рубля";
                        break;
                    case 2:
                        res += "рубля";
                        break;
                    case 3:
                        res += "рубля";
                        break;
                    default:
                        res += "рублей";
                        break;
                }

            }
            else { res += "рублей"; }
            Console.WriteLine(res);
        }

        public static void SplitJoin(string text)
        {
            string[] Word;

            Console.WriteLine();
            Word = text.Split(' ');
            foreach (var word2 in Word)
            {
                Console.WriteLine($"<{word2}>");
            }

            Console.WriteLine(String.Join(' ', Word));
        }

        public static void ExampleStringBuilder()
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder(100);
            System.Text.StringBuilder text = new System.Text.StringBuilder("String – example of StringBuilder");
            str.Insert(0, '2');
            str.Insert(1, '0'); 
            string res = str.ToString();

            Console.WriteLine(res);
            string str1 = "String1";
            str1 += " " + "String2"; 
            Console.WriteLine(str1);

            System.Text.StringBuilder str2 = new System.Text.StringBuilder(100);
            System.Text.StringBuilder str3 = new System.Text.StringBuilder(100);
            str2.Insert(0, '4');
            str2.Insert(1, '5');
            str3.Insert(0, '1');
            str3.Insert(1, '8');
            str2.Append(str3);
            string res2 = str2.ToString();
            Console.WriteLine(res2);

            str3.AppendFormat("{0} - {1}\n", res, "asd?");
            Console.WriteLine(str3.ToString());

            // 5
            Console.WriteLine("value for String {0}", str2.Capacity); 
            Console.WriteLine("value for Builder {0}", text.Capacity); 
            Console.WriteLine("Max value for String {0}", str2.MaxCapacity);
            Console.WriteLine("Max value for Builder {0}", text.MaxCapacity);
            text.EnsureCapacity(200);
            str2.EnsureCapacity(200);
            Console.WriteLine("value for String {0}", str2.Capacity);
            Console.WriteLine("value for Builder {0}", text.Capacity);
        }

        public static void CharArray()
        {
            char[] str1 = { '1', 'd', 'f' };
            string str2 = "Здравствуй, Мир!";
            string str3 = "";
            char[] str4 = { '6', '1', '2', '3', '5' };

            // print symbol
            for (var i = 0; i < str2.Length; i++)
            {
                Console.Write("{0}", str2[i]);
            }
            Console.WriteLine();

            // creating string
            for (var j = 0; j < str1.Length; j++)
            {
                str3 += str1[j];
            }
            Console.WriteLine(str3);

            // character occurrence 
            for (var i = 0; i < str2.Length; i++)
            {
                if (str2[i] == 'р')
                {
                    Console.WriteLine("вхождение символа: {0}", i);
                    break;
                }
            }

            string str5 = "Мир";
            int start = 0;
            int end = str2.Length;
            int count = 0;
            int at = 0;
            int flag = 0;
            str2.IndexOf(str5);

            while ((start <= end) && (at > -1))
            {
                count = end - start;
                at = str2.IndexOf(str5, start, count);
                if (at == -1) break;
                Console.Write("{0} ", at);
                if (at != 0)
                    flag = 1;
                if (flag == 1) break;
                start = at + 1;
            }
        }

    }
}
