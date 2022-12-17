Employee[] employees = new Employee[]
{
    new Employee{ Id=1,Name="Kassem",Gender="Male",TotalSales=50000m },
    new Employee{ Id=2,Name="Ahmed",Gender="Male",TotalSales=45000m },
    new Employee{ Id=3,Name="Mahmoud",Gender="Male",TotalSales=60000m },
    new Employee{ Id=4,Name="Ebrahim",Gender="Male",TotalSales=72000m },
    new Employee{ Id=5,Name="Abdo",Gender="Male",TotalSales=24000m },
};

Report report = new();

report.ProcessEmployeeWith60000PlusSales(employees);
report.ProcessEmployeeWith30000MinceSales(employees);
report.ProcessEmployeeBetween30000And59999(employees);