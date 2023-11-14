/*// 연습문제 7 - 1  |  이름 입력하기
{
    Console.WriteLine("이름을 입력해주세요. (3~10글자)");
    string input = Console.ReadLine();


    if (input.Length >= 3 && input.Length <= 10)
    {
        Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
    }
    else
    {
        Console.WriteLine("이름을 확인해주세요.");
    }
}

// 연습문제 7 - 2  |  조건에 맞을때 까지 이름 입력
{
    bool isSuccess;

    do
    {
        Console.WriteLine("이름을 입력해주세요. (3~10글자)");
        string input = Console.ReadLine();

        if (input.Length >= 3 && input.Length <= 10)
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
        }
        else
        {
            Console.WriteLine("이름을 확인해주세요.");
        }

        isSuccess = input.Length >= 3 && input.Length <= 10;
    }
    while (!isSuccess);
}

// 연습문제 7 - 3  |  반복시 기존 내용 지우기
{
    bool isSuccess;

    do
    {
        Console.WriteLine("이름을 입력해주세요. (3~10글자)");
        string input = Console.ReadLine();

        Console.Clear();

        if (input.Length >= 3 && input.Length <= 10)
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + input + " 입니다.");
        }
        else
        {
            Console.WriteLine("이름을 확인해주세요.");
        }

        isSuccess = input.Length >= 3 && input.Length <= 10;
    }
    while (!isSuccess);
}*/