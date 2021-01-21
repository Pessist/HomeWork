using System;

namespace Lesson2_check
{
    class Program
    {
        static void Main(string[] args)
        {
            double price, cash; // Стоимость товара и наличные
            string shop, street; //Название и улица
            string fullName = ""; //Полное имя товара
            string nameСashier = ""; //Имя кассира



            DateTime thisToday = DateTime.Today;
            Console.WriteLine("                                   Здравствуйте.Это хранилище ваших чеков. \n\n" +
                "            Как известно, чеки хранятся не долго, а гарания распростроняется на несколько лет.\n" +
                $"                       На сегоднящнюю дату " + thisToday.ToString("D") + " у Вас актуальных 3 чека:\n" +
                "                               смартфон, телевизор и стабилизатор напряжения.\n\n");

            Console.Write("Ведите наименование товара, чтобы посмотреть чек: ");
            string item = Console.ReadLine();

            if (item == "Смартфон" || item == "смартфон" || item == "телефон")
            {
                shop = "DNS";
                street = "350057 г. Краснодар, ул. Коммунаров, дом 278";
                price = 16_990.00;
                DateTime dateAndTime = new DateTime(2021, 1, 16, 14, 09, 51);
                DateTime dateCheque = new DateTime(2021, 1, 16, 14, 05, 23);
                fullName = "XIAOMI Redmi Note 9 128Gb";
                cash = 17_000.00;
                nameСashier = "Якунин Иван Сергеевич";
                


                Console.WriteLine($"\n\n\t\t     {shop}");
                Console.WriteLine($"{street}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"РН ККТ: 003025614327\t     {dateAndTime}");
                Console.WriteLine($"ЗН ККТ: 045661234386\t       СМЕНА: 432 Чек:21");
                Console.WriteLine("Сайт ФНС\t\t\t        nalog.ru");
                Console.WriteLine($"Кассир: {nameСashier}\t\t   #4214");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"1. 32584 {fullName}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ПОДИТОГ ЧЕКД:  {price} руб.\nЧек ККМ СМБШ-419100    от    {dateCheque}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ИТОГ\t\t\t\t\t  ={price}");
                Console.WriteLine($"  Наличными\t\t\t\t  ={price}\nПолучено:\t\t\t\t  ={cash}\nСдача\t\t\t\t\t     =" + (cash-price));

            }

            else if (item == "телевизор" || item == "Телевизор")
            {
                shop = "СИТИЛИНК";
                street = "350047 г. Краснодар, ул Монтажников, д.1/3, 2эт.";
                price = 43_950;
                DateTime dateAndTime = new DateTime(2019, 3, 8, 18, 15, 35);
                DateTime dateCheque = new DateTime(2019, 3, 8, 18, 10, 46);
                fullName = "Samsung UE50TU7570U";
                cash = 45_000;
                nameСashier = "Смирнов Николай Иванович";

                Console.WriteLine($"\n\n\t\t     {shop}");
                Console.WriteLine($"{street}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"РН ККТ: 148025874327\t     {dateAndTime}");
                Console.WriteLine($"ЗН ККТ: 545471484386\t       СМЕНА: 125 Чек:14");
                Console.WriteLine("Сайт ФНС\t\t\t        nalog.ru");
                Console.WriteLine($"Кассир: {nameСashier}\t   #6587");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"1. 13847 {fullName}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ПОДИТОГ ЧЕКД:  {price} руб.\nЧек ККМ СМБШ-513258    от    {dateCheque}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ИТОГ\t\t\t\t\t  ={price}");
                Console.WriteLine($"  Наличными\t\t\t\t  ={price}\nПолучено:\t\t\t\t  ={cash}\nСдача\t\t\t\t\t   =" + (cash - price));
            }

            else if (item == "стабилизатор напряжения" || item == "стабилизатор" || item == "Стабилизатор напряжения" || item == "Стабилизатор")
            {
                shop = "220 Вольт";
                street = "350059 г. Краснодар, ул. Уральская, 87/4";
                price = 2_250;
                DateTime dateAndTime = new DateTime(2020, 5, 3, 12, 32, 14);
                DateTime dateCheque = new DateTime(2020, 5, 3, 12, 27, 51);
                fullName = "РЕСАНТА АСН-1000/1-Ц, 1кВт";
                cash = 2_301;
                nameСashier = "Женетель Марина Васильевна";

                Console.WriteLine($"\n\n\t\t     {shop}");
                Console.WriteLine($"{street}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"РН ККТ: 534684145784\t     {dateAndTime}");
                Console.WriteLine($"ЗН ККТ: 135368555378\t         СМЕНА: 23 Чек:8");
                Console.WriteLine("Сайт ФНС\t\t\t        nalog.ru");
                Console.WriteLine($"Кассир: {nameСashier}\t   #1421");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"1. 53142 {fullName}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ПОДИТОГ ЧЕКД:  {price} руб.\nЧек ККМ СМБШ-642456    от    {dateCheque}");
                Console.WriteLine(("").PadRight(48, '-'));
                Console.WriteLine($"ИТОГ\t\t\t\t\t   ={price}");
                Console.WriteLine($"  Наличными\t\t\t\t   ={price}\nПолучено:\t\t\t\t   ={cash}\nСдача\t\t\t\t\t     =" + (cash - price));
            }

            else Console.Write("Вы ввели не правильное наименование товара, извините, программа будет закрыта, попробуйте еще раз.");

        }
    }
}
