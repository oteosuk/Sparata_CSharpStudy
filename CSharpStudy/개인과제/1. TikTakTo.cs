﻿namespace TikTakTo
{
    using static Console;

    class TikTakToMain
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Clear();
                WriteLine("플레이어 1: X 와 플레이어 2: O");
                WriteLine("\n");

                if (player % 2 == 0) WriteLine("플레이어 2의 차례");
                else WriteLine("플레이어 1의 차례");


                WriteLine("\n");
                Board();

                string line = ReadLine();
                bool res = int.TryParse(line, out choice);

                if (res == true)
                {
                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        if (player % 2 == 0) arr[choice] = 'O';
                        else arr[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        WriteLine("죄송합니다. {0} 행은 이미 {1}로 표시되어 있습니다.", choice, arr[choice]);
                        ReadLine();
                    }
                }
                else WriteLine("숫자를 입력해주세요.");


                flag = CheckWin();
            }
            while (flag != -1 && flag != 1);

            if (flag == 1) WriteLine("플레이어 {0}이(가) 이겼습니다.", (player % 2) + 1);
            else WriteLine("무승부");


            ReadLine();
        }

        static void Board()
        {
            WriteLine("     |     |     ");
            WriteLine("  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
            WriteLine("_____|_____|_____");
            WriteLine("     |     |     ");
            WriteLine("  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
            WriteLine("_____|_____|_____");
            WriteLine("     |     |     ");
            WriteLine("  {0}  |  {1}  |  {2}  ", arr[7], arr[8], arr[9]);
            WriteLine("     |     |     ");
        }

        static int CheckWin()
        {
            // 가로 승리 조건
            if (arr[1] == arr[2] && arr[2] == arr[3]) return 1;
            else if (arr[4] == arr[5] && arr[5] == arr[6]) return 1;
            else if (arr[7] == arr[8] && arr[8] == arr[9]) return 1;

            // 세로 승리 조건
            else if (arr[1] == arr[4] && arr[4] == arr[7]) return 1;
            else if (arr[2] == arr[5] && arr[5] == arr[8]) return 1;
            else if (arr[3] == arr[6] && arr[6] == arr[9]) return 1;

            // 대각선 승리조건
            else if (arr[1] == arr[5] && arr[5] == arr[9]) return 1;
            else if (arr[3] == arr[5] && arr[5] == arr[7]) return 1;

            // 무승부
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9') return -1;
            else return 0;
        }
    }
}