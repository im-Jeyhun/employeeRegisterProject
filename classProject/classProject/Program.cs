using System;

namespace classProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                editinfo:
                Console.Write("Insert Name : ");
                string targetName = Console.ReadLine();
                Console.Write("Insert Surname : ");
                string targetSurname = Console.ReadLine();
                Console.Write("Insert Father Name : ");
                string targetFatherName = Console.ReadLine();
                Console.Write("Insert Age : ");
                int targetAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert Finn number : ");
                string targetFin = Console.ReadLine();
                Console.Write("Insert Telephone number : +");
                string targetNumber = Console.ReadLine();
                Console.Write("Insert Position : ");
                string targetPosition = Console.ReadLine();
                Console.Write("Insert Salary : ");
                int targetSalary = Convert.ToInt32(Console.ReadLine());

                Employee hrEmp = new Employee(targetName, targetSurname, targetFatherName, targetAge, targetFin, targetNumber, targetName, targetSalary);
                Console.WriteLine(hrEmp.IsNameValid(targetName));
                Console.WriteLine(hrEmp.IsSurnameValid(targetSurname));
                Console.WriteLine( hrEmp.IsFatherNameValid(targetFatherName));
                Console.WriteLine( hrEmp.IsAgeValid(targetAge));
                Console.WriteLine (hrEmp.IsFinnValid(targetFin));
                Console.WriteLine( hrEmp.IsNumberValid(targetNumber));
                Console.WriteLine( hrEmp.IsPositionValid(targetPosition));
                Console.WriteLine(hrEmp.IsSalaryValid(targetSalary));
                Console.WriteLine("DATA APLLIED.....");

                Console.WriteLine("Whould you like to get Employee info or edit info ? press getinfo or editinfo");
                string targetGetInfo = Console.ReadLine();

                if (targetGetInfo == "getinfo")
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
                else if (targetGetInfo == "editinfo")
                {
                    goto editinfo;
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

        public bool IsNameValid(string empName)
        {
            bool isNameValid = true;
            if (!IsNameFirstCharUpper(empName))
            {
                Console.WriteLine("Adin ilk herfi boyuk olmalidir");
                isNameValid = false;
            }
            if (!IsNameLengthValid(empName))
            {
                Console.WriteLine("Ad minimum 2 max ise 20 herfli olmalidir.");
                isNameValid = false;
            }
            if (!IsNameConsistLetters(empName))
            {
                Console.WriteLine("Ad sadece herlferle yazilmalidir...");
                isNameValid = false;
            }

            return isNameValid;


        }
        public bool IsSurnameValid(string empSurName)
        {
            bool isSurNameValid = true;
            if (!IsNameFirstCharUpper(empSurName))
            {
                Console.WriteLine("Soyadin ilk herfi boyuk olmalidir");
                isSurNameValid = false;
            }
            if (!IsSurnameLengthValid(empSurName))
            {
                Console.WriteLine("Soyad minimum 2 max ise 35 herfli olmalidir.");
                isSurNameValid = false;
            }
            if (!IsNameConsistLetters(empSurName))
            {
                Console.WriteLine("Soyad sadece herlferle yazilmalidir...");
                isSurNameValid = false;
            }

            return isSurNameValid;

        }
        public bool IsFatherNameValid(string empFatherName)
        {
            bool isFatherNameValid = true;
            if (!IsNameFirstCharUpper(empFatherName))
            {
                Console.WriteLine("Ata adinin ilk herfi boyuk olmalidir");
                isFatherNameValid = false;
            }
            if (!IsNameLengthValid(empFatherName))
            {
                Console.WriteLine("Ata adi minimum 2 max ise 20 herfli olmalidir.");
                isFatherNameValid = false;
            }
            if (!IsNameConsistLetters(empFatherName))
            {
                Console.WriteLine("Ata adi sadece herlferle yazilmalidir...");
                isFatherNameValid = false;
            }

            return isFatherNameValid;
        }
        public bool IsAgeValid(int empAge)
        {
            bool isAgeValid = true;
            if (!IsAgeNumberValid(empAge))
            {
                Console.WriteLine("Yas araligi 18 - 65 arasi olmalidir...");
                isAgeValid = false;
            }
            return isAgeValid;
        }
        public bool IsAgeNumberValid(int empAge)
        {
            if (empAge <= 18 || empAge >= 65)
            {
                return false;
            }
            return true;

        }
        public bool IsFinnValid(string empFin)
        {
            bool isFinnValid = true;
            if (!IsFinnLengthValid(empFin))
            {
                Console.WriteLine("Finn code 7 charachter olmalidir");
                isFinnValid = false;
            }
            if (!IsFinnTextValid(empFin))
            {
                Console.WriteLine("Finn code sadece reqemlerden ve herflerden olmalidir.");
                isFinnValid = false;
            }
            return isFinnValid;
        }
        public bool IsFinnLengthValid(string empFin)
        {
            for (int i = 0; i < empFin.Length; i++)
            {
                if (empFin.Length < 7 || empFin.Length > 7)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsFinnTextValid(string empFin)
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
        public bool IsNumberValid(string empTelNumber)
        {
            bool isNumberValid = true;
            if (!IsNumberLengthValid(empTelNumber))
            {
                Console.WriteLine("Telefon nomresi 13 reqemli olmalidir");
                isNumberValid = false;
            }
            return isNumberValid;
        }
        public bool IsNumberLengthValid(string empTelNumber)
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

        public bool IsPositionValid(string empPosition)
        {
            bool isPositionValid = true;
            if (!IsPositionTextValid(empPosition))
            {
                Console.WriteLine("Pozisiyalar sadece HR, Audit , Engineer olmalidir");
                isPositionValid = false;
            }
            return isPositionValid;
        }
        public bool IsPositionTextValid(string empPosition)
        {
            if (empPosition != "HR" && empPosition != "Audit" && empPosition != "Engineer")
            {
                return false;
            }
            return true;
        }
        public bool IsSalaryValid(int empSalary)
        {
            bool isSalaryValid = true;
            if (!IsSalaryAmountValid(empSalary))
            {
                Console.WriteLine("Maas 1500 ile 5000 arasinda olmalidi");
                isSalaryValid = false;
            }
            return isSalaryValid;
        }
        public bool IsSalaryAmountValid(int empSalary)
        {
            if (empSalary < 1500 || empSalary > 5000)
            {
                return false;
            }
            return true;
        }

        public bool IsNameFirstCharUpper(string empName)
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
        public bool IsNameLengthValid(string empName)
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
        public bool IsNameConsistLetters(string empName)
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
        public bool IsSurnameLengthValid(string empName)
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

    }

}
   

