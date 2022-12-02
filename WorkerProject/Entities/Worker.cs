using System.Globalization;
using WorkerProject.Entities.Enuns;

namespace WorkerProject.Entities;

class Worker
{
    public string Name { get; set; }
    public WorkLevel Level { get; set; }
    public double BaseSalary { get; private set; }
   

    public Worker(string name, WorkLevel level, double baseSalary)
    {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
    }
    override
    public string ToString()
    {
        return " Name: " + Name +
            "\n Working level: " + Level +
            "\n Base Salary: $ " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture);
    }
   
}
