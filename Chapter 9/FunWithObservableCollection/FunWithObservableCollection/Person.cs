namespace FunWithObservableCollection
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(){}
        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format($"Name: {FirstName} {LastName}, Age: {Age}");
        }

    }
}
