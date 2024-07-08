namespace StringsAndStructures
{   
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание (1-6):");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Task1.Run();
                    break;
                case 2:
                    Task2.Run();
                    break;
                case 3:
                    Task3.Run();
                    break;
                case 4:
                    Task4.Run();
                    break;
                case 5:
                    Task5.Run();
                    break;
                case 6:
                    Task6.Run();
                    break;
                default:
                    Console.WriteLine("Неверный номер");
                    break;
            }
        }
    }

}


