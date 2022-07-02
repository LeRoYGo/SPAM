using System;

namespace SPAM
{
    class Worker : Employee
    {
        private string _fullNameManager;

        public Worker(string fullName, string birthDate, string gender, string fullNameManager) : base(fullName, birthDate, gender)
        {
            _fullNameManager = fullNameManager;
            _currentPosition = "Рабочий";
        }

        public override void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: { _currentPosition} | Имя: { _fullName} | Дата рождения: { _birthDate} | Пол: { _gender} | ФИО руковадителя: {_fullNameManager}");
    }
}