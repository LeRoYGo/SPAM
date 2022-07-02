using System;

namespace SPAM
{
    class HeadDivision : Employee
    {
        private string _nameDivision;
        public HeadDivision(string fullName, string birthDate, string gender, string nameDivision) : base(fullName, birthDate, gender)
        {
            _currentPosition = "Руководитель подразделения";
            _nameDivision = nameDivision;
        }

        public override void ShowInfo(int i) => Console.WriteLine($"№: {i} | Должность: { _currentPosition} | Имя: { _fullName} | Дата рождения: { _birthDate} | Пол: { _gender}  | Название подразделения: {_nameDivision}");
    }
}