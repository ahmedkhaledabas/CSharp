namespace Generics
{
    public class Person
    {
        public Person(string fName, string lName)
        {
            _fName = fName;
            _lName = lName;
        }

        private string _fName;
        private string _lName;

        public override string ToString()
        {
            return $"{_fName} {_lName}";
        }
    }
}
