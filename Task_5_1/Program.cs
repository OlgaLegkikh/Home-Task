//-Создайте базовый класс описывающий транспорт с произвольными полями и методом Move() описывающим способ передвижения в виде строки.
//- Добавьте производный(наследующий) класс описывающий лодку. Переопределите метод Move(), чтобы его поведение было актуально.
//- Добавьте производный класс описывающий автомобиль.  Переопределите метод Move() чтобы его поведение было актуально.

//Добавьте производный класс описывающий Человека.
//- Добавьте скрытое поле типа Транспорт.
//- Создайте метод выводящий информацию о том, как Человек передвигается.
//- Смена типа транспорта возможна исключительно через свойство(Property) либо метод.
//- В методе Main() класса Program объявите переменную типа транспорт и присвойте экземпляр любого производного класса.
//- Проверьте поведение вашего кода для различных экземпляров производных классов.

using System;

namespace Task_5_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Olk = new Person("Ольк");
            Console.WriteLine("В класс Person не передан экземпляр класса Vehicle:");
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Vehicle(Car):");
            Vehicle duster = new Car();
            duster.Brand = "Renault";
            duster.Move();
            Olk.ChangeVehicle(duster);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Car:");
            var emgrand = new Car();
            emgrand.Brand = "Geely";
            emgrand.Move();
            Olk.ChangeVehicle(emgrand);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Boat с значением Brand по умолчанию:");
            var boat_1 = new Boat();
            boat_1.Move();
            Olk.ChangeVehicle(boat_1);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Vehicle(Boat) и Brand не задан:");
            Vehicle boat_2 = new Boat();
            boat_2.Move();
            Olk.ChangeVehicle(boat_2);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Boat:");
            var boat_3 = new Boat();
            boat_3.Brand = "Флинк";
            boat_3.Move();
            Olk.ChangeVehicle(boat_3);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

            Console.WriteLine("В класс Person передан экземпляр класса Vehicle(Boat):");
            Vehicle boat_4 = new Boat();
            boat_4.Brand = "Хантер";
            boat_4.Move();
            Olk.ChangeVehicle(boat_4);
            Olk.PersonMove();
            Console.Write(Environment.NewLine);

        }
    }
}
