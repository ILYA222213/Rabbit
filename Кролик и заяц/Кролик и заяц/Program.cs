internal class Program
{
    static void MyThreadTurtle()
    {
        for (int i = 0; i < 100; i++) //Цикл,который будет выполнятся 100 раз
        {
            Console.WriteLine("Черепаха прошла: " + i); //Выводим сообщение о прохождении черепахи с текущим значением i
        }
    }
    private static void Main(string[] args)
    {
        Thread turtle = new(MyThreadTurtle); //Создаем новый поток с методом MyThreadTurtle
        turtle.Start(); //Запускаем поток

        for (int i = 0; i < 100; i++) //Цикл, который будет выполняться 100 раз
        {
            Console.WriteLine("Кролик прошел: " + i); //Выводим сообщение о прохождении кролика с текущим значением i
        }
    }
}