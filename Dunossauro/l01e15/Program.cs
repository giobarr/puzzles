Console.WriteLine("Quanto você ganha por hora?");
decimal hourlyWage = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Número de horas trabalhadas no mês:");
decimal hoursWorked = decimal.Parse(Console.ReadLine() ?? "0");

// Calculate gross salary
decimal grossSalary = hourlyWage * hoursWorked;

// Calculate deductions
decimal ir = grossSalary * 0.11m;
decimal inss = grossSalary * 0.08m;
decimal sindicato = grossSalary * 0.05m;

// Calculate total deductions and net salary
decimal totalDeductions = ir + inss + sindicato;
decimal netSalary = grossSalary - totalDeductions;

// Display results
Console.WriteLine();
Console.WriteLine($"+ Salário Bruto : R$ {grossSalary:F2}");
Console.WriteLine($"- IR (11%) : R$ {ir:F2}");
Console.WriteLine($"- INSS (8%) : R$ {inss:F2}");
Console.WriteLine($"- Sindicato (5%) : R$ {sindicato:F2}");
Console.WriteLine($"= Salário Liquido : R$ {netSalary:F2}");
