﻿/*Основная версия ДЗ:

Создать абстрактный класс Person, описывающий человека;
(Дать ему 2-4 поля/свойства + год рождения)

В класс Person добавить обычный метод для подсчёта текущего возраста.

В класс Person добавить виртуальный метод для вывода на экран всей доступной информации в читаемом виде;

В класс Person добавить абстрактный метод void SolveProblem().

Создать класс-наследник Employee и переопределить метод для вывода на экран всей информации, теперь уже о сотруднике;
(Дать ему ещё 2-4 поля/свойства, + название должности)

Реализовать метод SolveProblem класса Employee — вывод в консоль того, что делает этот Employee, в зависимости от значения его должности.

Создать ещё одного неабстрактного наследника Person — Customer — и переопределить метод для вывода на экран всей информации о нём, теперь уже клиенте. Обычно у клиентов есть какие-нибудь контактные/платёжные/адресные данные.  ; )

Воспользоваться методами этих объектов.*/

using System;

namespace Task_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var employee1 = new Employee("Маша","Иванова",1991);

            employee1.SolveProblem();

        }
    }
}