using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14226
{
    internal class 이모티콘
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            // BFS 활용
            // 방문했는지 표시를 해주는 변수 (이모티콘, 클립보드)
            bool[,] enter = new bool[1001, 1001];
            // que에 (이모티콘, 클립보드, 시간)을 담기위해 튜플형태로 담는다.
            Queue<(int, int, int)> que = new Queue<(int,int, int)>();
            // 스타트 국룰
            que.Enqueue((1, 0, 0));
            enter[1, 0] = true;

            while(que.Count > 0) 
            {
                var (emote, clipboard, time) = que.Dequeue();
                if(emote == s)
                {
                    Console.WriteLine(time);
                    return;
                }

                // 클립보드 저장
                if (!enter[emote, emote])
                {
                    enter[emote, emote] = true;
                    que.Enqueue((emote, emote, time + 1));
                }

                // 클립보드 붙여넣기
                // 조건 설명
                // 1. 클립보드에 값이 있어야한다.
                // 2. 클립보드를 붙여넣었을때 조건중 하나인 1000을 넘어서는 안된다.
                // 3. 붙여넣었을 때 이미 방문한 곳이 아니여야 한다.
                if(clipboard > 0 && emote + clipboard <= 1000 && !enter[emote + clipboard, clipboard])
                {
                    enter[emote + clipboard, clipboard] = true;
                    que.Enqueue((emote + clipboard, clipboard, time + 1));
                }

                // 이모티콘 삭제
                if(emote > 1 && !enter[emote - 1, clipboard])
                {
                    enter[emote - 1, clipboard] = true;
                    que.Enqueue((emote - 1, clipboard, time +1));
                }
            }
        }
    }
}
