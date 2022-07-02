using System;
using System.Collections.Generic;

namespace SPAM
{
    static class SystemPersonnelAccountingManagement
    {
        private static List<Employee> _employeesCompany;

        static SystemPersonnelAccountingManagement()
        {
            _employeesCompany = new List<Employee> { new Director(" efferf eref efre g", " ferfefefef  efe rer", "   dfer "), new Worker("ferfeferfe", "ferferegre", "ferfef", "refrefe") };
        }
        public static void Main()
        {
            Console.WriteLine("**********************Система Управления Кадровым Учетом**********************");
            SelectAction();
        }

        private static void SelectAction()
        {
            bool isExit = false;
            while (isExit == false)
            {
                Console.WriteLine("1 - Показать список всех сотрудников\n2 - Добавить новое досье сотрудника\n3 - Удалить досье сотрудника\n4 - Редактировать досье сотрудника" +
                                  "\n5 - Повышение в должности сотрудника\n6 - Выборка сотрудников по должности\n7 - Выборка сотрудников по подразделениям\n8 - Завершить работу");
                Console.Write("Выберите действие: ");
                int.TryParse(Console.ReadLine(), out int numberUserInput);

                switch (numberUserInput)
                {
                    case 1:
                        ShowInfoEmployeesAll();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет в меню. Попробуйте сново.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void ShowInfoEmployeesAll()
        {
            if (_employeesCompany.Count == 0)
            {
                Console.Write("Список пуст");
            }
            else
            {
                for (int i = 0; i < _employeesCompany.Count; i++)
                {
                    _employeesCompany[i].ShowInfo(i + 1);
                }
            }
        }
    }

    abstract class Employee
    {
        private protected string FullName;
        private protected string BirthDate;
        private protected string Gender;
        private protected string CurrentPosition;

        public Employee(string fullName, string birthDate, string gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public virtual void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: {CurrentPosition} | Имя: {FullName} | Дата рождения: {BirthDate} | Пол: {Gender}");
    }

    class Director : Employee
    {
        public Director(string fullName, string birthDate, string gender) : base(fullName, birthDate, gender)
        {
            CurrentPosition = "Директор";
        }
    }

    class HeadDivision : Employee
    {
        private string NameDivision;
        public HeadDivision(string fullName, string birthDate, string gender, string nameDivision) : base(fullName, birthDate, gender)
        {
            CurrentPosition = "Руководитель подразделения";
            NameDivision = nameDivision;
        }

        public override void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: { CurrentPosition} | Имя: { FullName} | Дата рождения: { BirthDate} | Пол: { Gender}  | Название подразделения: {NameDivision}");
    }

    class Worker : Employee
    {
        private string FullNameManager;

        public Worker(string fullName, string birthDate, string gender, string fullNameManager) : base(fullName, birthDate, gender)
        {
            FullNameManager = fullNameManager;
            CurrentPosition = "Рабочий";
        }

        public override void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: { CurrentPosition} | Имя: { FullName} | Дата рождения: { BirthDate} | Пол: { Gender} | ФИО руковадителя: {FullNameManager}");
    }
}