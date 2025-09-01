using System; // Import the System namespace for basic functionality

namespace EmployeeComparisonApp // Define the namespace for the application
{
    class Program
    {
        // Main method: entry point of the application
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "Zeinab";
            emp1.LastName = "Abou Hueili";

            // Create the second Employee object
            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.FirstName = "Sam";
            emp2.LastName = "Smith";

            // Compare the two employees using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 and emp2 are equal based on Id.");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are NOT equal based on Id.");
            }

            // Compare using the overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("emp1 and emp2 are different based on Id.");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are NOT different based on Id.");
            }

            // Keep console open
            Console.ReadLine();
        }
    }

    // Define the Employee class
    class Employee
    {
        // Property to store the employee's ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Return true if Ids are equal
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be done in pairs)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Use the == operator logic and invert it
        }

        // Override Equals to be consistent with == operator
        public override bool Equals(object obj)
        {
            var other = obj as Employee;

            if (other == null)
                return false;

            return this.Id == other.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
