using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Programmer { get; private set; }
        public Employee(string name, int age, bool programmer)
        {
            Name = name;
            Age = age;
            Programmer = programmer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
