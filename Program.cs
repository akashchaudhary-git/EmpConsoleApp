using EmpClassLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        // Set organization name
        Employee.OrganizationName = "Harsha Inc.";

        // Create up to 5 employee objects
        for (int i = 0; i < 5; i++)
        {
            // Read employee details from user
            Console.Write("Enter employee ID: ");
            int empID = int.Parse(Console.ReadLine());

            Console.Write("Enter employee name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter employee salary per hour: ");
            double salaryPerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter number of working hours: ");
            int noOfWorkingHours = int.Parse(Console.ReadLine());

            // Create employee object
            Employee emp = new Employee(empID, empName, salaryPerHour, noOfWorkingHours);

            // Display employee details
            Console.WriteLine("Employee ID: " + emp.EmpID);
            Console.WriteLine("Employee Name: " + emp.EmpName);
            Console.WriteLine("Salary Per Hour: " + emp.SalaryPerHour);
            Console.WriteLine("Number of Working Hours: " + emp.NoOfWorkingHours);
            Console.WriteLine("Net Salary: " + emp.NetSalary);
            Console.WriteLine("Organization Name: " + Employee.OrganizationName);
            Console.WriteLine("Type of Employee: " + Employee.TypeOfEmployee);
            Console.WriteLine("Department Name: " + emp.DepartmentName);

            // Ask if user wants to continue
            Console.Write("Do you want to continue to next employee? (Y/N): ");
            string choice = Console.ReadLine();

            // Check if user wants to continue or not
            if (choice.ToUpper() == "N")
            {
                break;
            }
        }
    }
}