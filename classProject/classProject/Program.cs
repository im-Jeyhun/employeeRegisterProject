using System;

namespace classProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Notes : (Name's first char must be start with upper letter, letter's must be upper than 2, less than 20, Name must be consist of letters)");
                Console.Write("Insert Name : ");
                string targetName = Console.ReadLine();
                Console.WriteLine("Notes : (Surname's first char must be start with upper letter, letter's must be upper than 2, less than 35, Surname must be consist of letters)");
                Console.Write("Insert Surname : ");
                string targetSurname = Console.ReadLine();
                Console.WriteLine("Notes : (Father's first char must be start with upper letter, letter's must be upper than 2, less than 35, Father must be consist of letters)");
                Console.Write("Insert Father Name : ");
                string targetFatherName = Console.ReadLine();
                Console.WriteLine("Notes : (Age must be between 18 and 65)");
                Console.Write("Insert Age : ");
                int targetAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Notes : (Finn must be 7 char , in Finn number must be upper letters and figures)");
                Console.Write("Insert Finn number : ");
                string targetFin = Console.ReadLine();
                Console.WriteLine("Notes : (Telephone number must be 13 fiqures and Tel number must me start with +994)");
                Console.Write("Insert Telephone number : +");
                string targetNumber = Console.ReadLine();
                Console.WriteLine("Notes : (Position consist of HR, Audit , Engineer)");
                Console.Write("Insert Position : ");
                string targetPosition = Console.ReadLine();
                Console.WriteLine("Notes : (Salary's amount must be between 1500 and 5000)");
                Console.Write("Insert Salary : ");
                int targetSalary = Convert.ToInt32(Console.ReadLine());


                Employee hrEmp = new Employee(targetName, targetSurname, targetFatherName, targetAge, targetFin, targetNumber, targetName, targetSalary);
                Console.WriteLine($"Name is {hrEmp.NameChechk(targetName)}");
                Console.WriteLine($"Surname is {hrEmp.SurnameChechk(targetSurname)}");
                Console.WriteLine($"Father name is {hrEmp.FatherNameChechk(targetFatherName)}");
                Console.WriteLine($"Age is {hrEmp.AgeChechker(targetAge)}");
                Console.WriteLine($"Finn is {hrEmp.MainFinnChechk(targetFin)}");
                Console.WriteLine($"Telephone number is {hrEmp.FirstNumberChechk(targetNumber)}");
                Console.WriteLine($"Position is {hrEmp.PositionChechk(targetPosition)}");
                Console.WriteLine($"Salary is {hrEmp.SalaryChechk(targetSalary)}");
                Console.WriteLine("Whould you like to get Employee info ? press yes or no");
                string targetGetInfo = Console.ReadLine();

                if (targetGetInfo == "yes")
                {
                    Console.WriteLine($"Employe's name is {targetName}");
                    Console.WriteLine($"Employe's surname is {targetSurname}");
                    Console.WriteLine($"Employe's father name is {targetFatherName}");
                    Console.WriteLine($"Employe's age is {targetAge}");
                    Console.WriteLine($"Employe's finn number is {targetFin}");
                    Console.WriteLine($"Employe's number is {targetNumber}");
                    Console.WriteLine($"Employe's position is {targetPosition}");
                    Console.WriteLine($"Employe's salary is {targetSalary}");
                }
                else
                {
                    Console.WriteLine("Bye-Bye");
                }
            }
        }
    }

    class Employee
    {
        public string _empName;
        public string _empSurName;
        public string _empFatherName;
        public int _empAge;
        public string _empFin;
        public string _empTelNumber;
        public string _empPosition;
        public int _empSalary;

        public Employee(string empName, string empSurName, string empFatherName, int empAge, string empFin, string empTelNumber, string empPosition, int empSalary)
        {
            _empName = empName;
            _empSurName = empSurName;
            _empFatherName = empFatherName;
            _empAge = empAge;
            _empFin = empFin;
            _empTelNumber = empTelNumber;
            _empPosition = empPosition;
            _empSalary = empSalary;
        }

        public bool NameChechk(string empName)
        {
            return FirstNameMethod(empName) && SecondNameMethod(empName) && ThirdNameMethod(empName);

        }
        public bool SurnameChechk(string empSurName)
        {
            return FirstNameMethod(empSurName) && SecondSNameMethod(empSurName) && ThirdNameMethod(empSurName);
        }
        public bool FatherNameChechk(string empFatherName)
        {
            return FirstNameMethod(empFatherName) && SecondNameMethod(empFatherName) && ThirdNameMethod(empFatherName);
        }
        public bool MainFinnChechk(string empFin)
        {
            return FirstFinCheck(empFin) && SecondFinCheck(empFin);
        }
        public bool MainNumberChechk(string empTelNumber)
        {
            return FirstNumberChechk(empTelNumber);
        }
        public bool FirstNameMethod(string empName)
        {
            char[] alphabetLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < alphabetLower.Length; i++)
            {
                if (empName[0] == alphabetLower[i])
                {
                    return false;
                }
            }
            return true;
        }
        public bool SecondNameMethod(string empName)
        {
            for (int i = 0; i < empName.Length; i++)
            {
                if (empName.Length <= 2 || empName.Length >= 20)
                {
                    return false;
                }
            }
            return true;
        }
        public bool ThirdNameMethod(string empName)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (empName[0] == alphabet[i])
                {
                    return true;
                }
            }
            return false;
        }
        public bool SecondSNameMethod(string empName)
        {
            for (int i = 0; i < empName.Length; i++)
            {
                if (empName.Length <= 2 || empName.Length >= 35)
                {
                    return false;
                }
            }
            return true;
        }
        public bool AgeChechker(int empAge)
        {
            if (empAge <= 18 || empAge >= 65)
            {
                return false;
            }
            return true;

        }
        public bool FirstFinCheck(string empFin)
        {
            for (int i = 0; i < empFin.Length; i++)
            {
                if (empFin.Length < 7 || _empName.Length > 7)
                {
                    return false;
                }
            }
            return true;
        }
        public bool SecondFinCheck(string empFin)
        {
            char[] alphabets = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < alphabets.Length; i++)
            {
                for (int k = 0; k < empFin.Length; k++)
                {
                    if (empFin[k] == alphabets[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool FirstNumberChechk(string empTelNumber)
        {
            foreach (char elem in empTelNumber)
            {
                if (elem < '0' || elem > '9' || empTelNumber.Length < 12 || empTelNumber.Length > 12)
                {
                    return false;
                }
            }
            return true;
        }
        public bool PositionChechk(string empPosition)
        {
            if (empPosition != "HR" && empPosition != "Audit" && empPosition != "Engineer")
            {
                return false;
            }
            return true;
        }
        public bool SalaryChechk(int empSalary)
        {
            if (empSalary < 1500 || empSalary > 5000)
            {
                return false;
            }
            return true;
        }
    }
}