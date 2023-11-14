namespace CSharpStudy
{
    using static Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("이름을 입력하세요: ");
            string name = ReadLine();
            Write("나이를 입력하세요: ");
            string age = ReadLine();
            WriteLine("안녕하세요, {0}! 당신은 {1} 세 이군요.", name, age);
        }
    }
}