/*
 * Created by Mad Nomad
 * Date: 25.01.2016
 * Time: 15:52
 */
using System;

namespace Employee
{
	/// <summary>
	/// Description of Employee.
	/// </summary>
	public class Employee
	{
		string nameFirst;
		string nameLast;
		string position = "SomePosition";
		double baseSalary = 100;
		double baseTaxFee = 20;
		double salary;
		double tax;
		
		public Employee(string nFirst, string nLast)
		{
			nameFirst = nFirst;
			nameLast = nLast;
		}
		
		public void Salary ()
		{
			if (position.Equals("SomePosition"))
			{
				salary = baseSalary * 1;
				tax = baseSalary * (baseTaxFee/100);
			}
			Console.WriteLine("ФИО\t\t\tДолжность\t\tОклад\tНалог");
			Console.WriteLine("{0} {1}\t\t{2}\t\t{3}\t{4}", nameFirst, nameLast, position, salary, tax);
		}
	}
}
