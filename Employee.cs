using System;

namespace SPAM
{
    abstract class Employee
    {
        private protected string _fullName;
        private protected string _birthDate;
        private protected string _gender;
        private protected string _currentPosition;

        public Employee(string fullName, string birthDate, string gender)
        {
            _fullName = fullName;
            _birthDate = birthDate;
            _gender = gender;
        }

        public virtual void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: {_currentPosition} | Имя: {_fullName} | Дата рождения: {_birthDate} | Пол: {_gender}");
    }
}