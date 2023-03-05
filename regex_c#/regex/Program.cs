// See https://aka.ms/new-console-template for more information

//task2

string[] employees = new string[0];
int count = 0;

while (true)
{

    Console.Write("Enter new employee: ");
    string employeeName = Console.ReadLine();


    Array.Resize(ref employees, count + 1);
    employees[count] = employeeName;
    count++;


    Console.Write("do you want to continue? (yes or no) ");
    string answer = Console.ReadLine();

    if (answer == "no" || answer == "No")
    {

        foreach (string emp in employees)
        {
            Console.WriteLine(emp);
        }
        break;
    }
}





