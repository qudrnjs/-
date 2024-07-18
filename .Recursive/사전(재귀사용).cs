using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "AAAAE";
            int ret1 = solution(word1);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret1);

            string word2 = "AAAE";
            int ret2 = solution(word2);

            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            Console.WriteLine("solution 함수의 반환 값은 {0} 입니다.", ret2);

        }

        static string[] vowels = { "A", "E", "I", "O", "U" };
        static List<string> words = new List<string>();

        static void create_words(int lev, string str)
        {
            words.Add(str);
            for (int i = 0; i < 5; i++)
            {
                if (lev < 5)
                {
                    create_words(lev + 1,str + vowels[i]);
                }
            }
        }

        static int solution(string word)
        {
            int answer = 0;
            words.Clear();
            create_words(0, "");
            int words_n = words.Count;
            for (int i = 0; i < words_n; i++)
            {
                if (word == words[i])
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
}
