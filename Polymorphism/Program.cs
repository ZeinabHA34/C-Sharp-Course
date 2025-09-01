using System; // Provides access to fundamental system functions like Console

namespace EmployeeQuitApp // Define the namespace of the application
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Declare a method with no return value
        void Quit();
    }

    // Define the Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Property to store the employee's ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Implement the Quit method from IQuittable interface
        public void Quit()
        {
            // Example implementation: print a message to the console
            Console.WriteLine($"{FirstName} {LastName} (Employee ID: {Id}) has quit the job.");
        }

        // Overload == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload != operator (must be done in pairs)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match == behavior
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null) return false;
            return this.Id == other.Id;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Employee class
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Zeinab";
            employee.LastName = "Abou Hueili";

            // Use polymorphism: declare a variable of interface type IQuittable
            IQuittable quittable = employee; // Assign the employee object to it

            // Call the Quit method via the interface reference
            quittable.Quit(); // This executes Employee's implementation of Quit()


        }
    }
}
