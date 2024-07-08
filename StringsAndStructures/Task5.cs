using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace StringsAndStructures
{
    struct Client
    {
        public int ClientCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int NumberOfOrders { get; set; }
        public decimal TotalOrderAmount { get; set; }

        public Client(int clientCode, string fullName, string address, string phone, int numberOfOrders, decimal totalOrderAmount)
        {
            ClientCode = clientCode;
            FullName = fullName;
            Address = address;
            Phone = phone;
            NumberOfOrders = numberOfOrders;
            TotalOrderAmount = totalOrderAmount;
        }

        public void Print()
        {
            Console.WriteLine($"Код клиента: {ClientCode}");
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Телефон: {Phone}");
            Console.WriteLine($"Количество заказов: {NumberOfOrders}");
            Console.WriteLine($"Общая сумма заказов: {TotalOrderAmount}");
        }
    }

    internal class Task5
    {
        public static void Run()
        {
            // 5) Описать структуру Client, содержащую поля: код клиента; ФИО; адрес; телефон;
            // количество заказов, осуществленных клиентом; общая сумма заказов клиента.
            // Включите в структуру конструктор с параметрами и метод Print().
            // Создать экземпляр структуры.
            Console.WriteLine("\n5 задание");

            Client client = new Client(
                clientCode: 1,
                fullName: "Бучко Виктория Игоревна",
                address: "Садовая",
                phone: "12345678",
                numberOfOrders: 10,
                totalOrderAmount: 2000m
            );

            client.Print();
        }
    }
}

