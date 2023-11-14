/*// 연습문제 6 - 1  |  구구단 2단을 만들기
{
    for (int i = 2; i <= 9; i++)
    {
        Console.WriteLine("2 x " + i + " = " + 2 * i);
    }
}

// 연습문제 6 - 2  |  입력받은 데이터로 구구단 만들기
{
    Console.WriteLine("출력하고 싶은 단을 입력해주세요.");
    string input = Console.ReadLine();
    int num;
    bool isInt = int.TryParse(input, out num);

    if (isInt)
    {
        for (int i = 2; i <= 9; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + num * i);
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}

// 연습문제 6 - 3  |  피보나치 수열 구하기
{
    int first = 0;
    int second = 1;

    int count = 0;

    while (count < 10)
    {
        Console.Write(second + " ");
        int result = first + second;
        first = second;
        second = result;
        count++;
    }
}

// 연습문제 6 - 4  |  입력받은 수만큼 피보나치 수열 구하기
{
    Console.WriteLine("몇개의 피보나치 수열을 출력하고 싶으신가요?");
    string input = Console.ReadLine();
    int num;
    bool isInt = int.TryParse(input, out num);

    if (isInt)
    {

        if (num > 0)
        {
            if (num >= 47)
            {
                Console.WriteLine("숫자가 너무 큽니다.");
            }
            else
            {
                int first = 0;
                int second = 1;

                int count = 0;

                while (count < num)
                {
                    Console.Write(second + " ");
                    int result = first + second;
                    first = second;
                    second = result;
                    count++;
                }
            }
        }
        else
        {
            Console.WriteLine("양수를 입력해주세요.");
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}*/