using System.Diagnostics.Contracts;
using System.Globalization;
using WorkerProject.Entities.Enuns;

namespace WorkerProject.Entities;

class Worker
{
    public string Name { get; set; }
    public WorkLevel Level { get; set; }
    public double BaseSalary { get; private set; }
    public Department department { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();


    public Worker(string name, Department department, WorkLevel level, double baseSalary)
    {
        Name = name;
        this.department = department;
        Level = level;
        BaseSalary = baseSalary;
    }
    override
    public string ToString()
    {
        return " Name: " + Name +
            "\n Working level: " + Level +
            "\n Department: " + department.Name +
            "\n Base Salary: $ " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture);
    }
    public void AddContract(HourContract contract)
    {
        if (contract != null)
        {
            Contracts.Add(contract);

        }
    }
    public void RemoveContract(HourContract contract)
    {
        if (contract != null)
        {
            Contracts.Remove(contract);

        }
    }
    public double Income(int month, int year)
    {
        double sun = BaseSalary;
        foreach (HourContract obj in Contracts)

        {
            if (obj.Date.Month == month && obj.Date.Year == year)
            {
                sun += obj.TotalValue();
            }
        }
        return sun;
    }


}
