using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

/*
1.이름 나열
2. 이름 섞기
3. 섞인 이름 출력
4. 이름 재배치 - 선택정렬 알고리즘 (선택된 값과 나머지 데이터중에 비교하여 알맞은 자리를 찾는 알고리즘)
 */

namespace NameSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 이름 나열
            string[] ourClassNames = new string[]
            {
                "김동록", "김소원", "김시현",
                "김지원", "박현웅", "프로도", "유승호",
                "윤식", "이도경", "인뚝이", "전지수", "정진경",
                "조재광", "준겸", "최유민", "태욱", "현정", "황수연", "황지후"
            };

            //2. 이름 섞기
            Random rand = new Random();
            int random1, random2;
            string temp;
            for (int i = 0; i < ourClassNames.Length; ++i)
            {
                random1 = rand.Next(0, ourClassNames.Length);
                random2 = rand.Next(0, ourClassNames.Length);

                temp = ourClassNames[random1];
                ourClassNames[random1] = ourClassNames[random2];
                ourClassNames[random2] = temp;
            }

            //3. 섞인 이름 출력
            WriteLine("섞인 이름들");
            foreach(var name in ourClassNames)
            {
                Write(name + ", ");
            }

            //4. 이름 순서 나열하기
            //4-1. 첫번째 이름부터 비교 시작
            for (int i = 0; i < ourClassNames.Length; i++)
            {
                //4-2. 해당 값을 최소값이라고 가정하고 시작한다.
                int minStringNumber = i;

                //4-3. 해당 값이후 값들과 비교를 한다.
                for(int j = i + 1; j < ourClassNames.Length; j++)
                {
                    //4-4. 이름은 3글자이기 때문에 3번 비교를 진행한다.
                    for (int k = 0; k < 3; k++)
                    {
                        //4-5. 이름이 2글자일 수도 있기 때문에, 만약 2번째 글자까지 같다면 패스한다.
                        if (ourClassNames[j].Length < k + 1 || ourClassNames[minStringNumber].Length < k + 1)
                        {
                            break;
                        }

                        //4-6. k번째의 글자 값을 비교한다(k가 0이라면 성의 수치값을 비교한다)
                        if (ourClassNames[j][k] < ourClassNames[minStringNumber][k])
                        {
                            //4-7. 만약, 최소값이라고 생각했던 값보다 더 작은 수치가 나오면 해당 번째를 최소값으로 지정한다.
                            minStringNumber = j;
                            break;
                        }

                        //4-8. 같은 성씨(또는 해당번째의 같은 글자)가 아닌경우는 작다고 판단하기 때문에 넘긴다. (다음글자를 볼 필요가 없으니 넘긴다)
                        if(ourClassNames[j][k] != ourClassNames[minStringNumber][k])
                        {
                            break;
                        }
                    }
                }

                //4-9. 값을 바꾼다.
                string temp2;
                temp2 = ourClassNames[i];
                ourClassNames[i] = ourClassNames[minStringNumber];
                ourClassNames[minStringNumber] = temp2;
            }

            WriteLine("\n\n\n\n\n최종결과 :"); 
            foreach (var name in ourClassNames)
            {
                Write(name + ", ");
            }


            ReadKey();
        }
    }
}
