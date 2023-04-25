using ChallengeApp;
char sp = ' ';

Employee employee1 = new Employee("Adam", "Wilk", 22);          //31    
Employee employee2 = new Employee("Monika", "Żyła", 33);        //18
Employee employee3 = new Employee("Zuzana", "Drabik", 29);      //36
Employee employee4 = new Employee("Damian", "Bąk", 44);         //42

employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);

employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(9);

employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(15);
employee3.AddScore(8);
employee3.AddScore(22);

employee4.AddScore(9);
employee4.AddScore(7);
employee4.AddScore(9);
employee4.AddScore(8);
employee4.AddScore(9);

List<Employee> employers = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

var BestResoult = -1;
Employee BestEmployee = null;

foreach (var employee in employers)
{
    if (employee.Result > BestResoult)
    {
        BestResoult = employee.Result;
        BestEmployee = employee;
    }
 
}
Console.WriteLine("Najlepszym pracownikiem jest: " + BestEmployee.Name + " " + BestEmployee.Surname);
Console.WriteLine("z wynikiem: " + BestEmployee.Result);
Console.WriteLine("który ma: " + BestEmployee.Age + sp + "lat");