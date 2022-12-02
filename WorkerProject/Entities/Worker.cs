using System.Diagnostics.Contracts;
using System.Globalization;
using WorkerProject.Entities.Enuns;

namespace WorkerProject.Entities;

class Worker
{
    public string Name { get; set; }
    public WorkLevel Level { get; set; }
    public double BaseSalary { get; private set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();


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
    public void AddContract(HourContract contract)
    {
        if (contract != null && !Contracts.Contains(contract))
        {

            Contracts.Add(contract);
        }
    }
    public void RemoveContract(HourContract contract)
    {
        if (contract != null && Contracts.Contains(contract))
        {
            Contracts.Remove(contract);
        }
    }


}
