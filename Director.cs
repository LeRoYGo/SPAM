namespace SPAM
{
    class Director : Employee
    {
        public Director(string fullName, string birthDate, string gender) : base(fullName, birthDate, gender)
        {
            _currentPosition = "Директор";
        }
    }
}