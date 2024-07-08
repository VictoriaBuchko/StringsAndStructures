using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStructures
{
    struct Request
    {
        public int OrderCode { get; set; }
        public Client Client { get; set; }
        public DateTime OrderDate { get; set; }
        public string[] OrderedItems { get; set; }
        public float OrderPrice { get; set; }

        public Request(int orderCode, Client client, DateTime orderDate, string[] orderedItems, float orderPrice)
        {
            OrderCode = orderCode;
            Client = client;
            OrderDate = orderDate;
            OrderedItems = orderedItems;
            OrderPrice = orderPrice;
        }
        public void Print()
        {
            Console.WriteLine($"Код заказа: {OrderCode}");
            Console.WriteLine($"Дата заказа: {OrderDate}");
            Console.WriteLine("Клиент:");
            Client.Print();
            Console.WriteLine("Перечень заказанных товаров:");
            foreach (var item in OrderedItems)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Сумма заказа: {OrderPrice}");
        }
    }

    internal class Task6
    {
        public static void Run()
        {
            //6) Описать структуру Request, содержащую поля:
            //код заказа; клиент; дата заказа; перечень заказанных товаров;
            //сумма заказа. Включите в структуру конструктор с параметрами
            //и метод Print().Создать экземпляр структуры.
            Console.WriteLine("\n6 задание");
            string[] orderedItems = { "1", "2", "3" };

            Client client = new Client(
               clientCode: 1,
               fullName: "Бучко Виктория Игоревна",
               address: "Садовая",
               phone: "12345678",
               numberOfOrders: 10,
               totalOrderAmount: 2000m
           );

            Request request = new Request(
                orderCode: 2,
                client: client,
                orderDate: DateTime.Now,
                orderedItems: orderedItems,
                orderPrice: 1500
            );
            request.Print();
        }
    }
}
