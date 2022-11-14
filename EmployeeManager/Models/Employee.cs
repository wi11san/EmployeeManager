using System;

namespace EmployeeManager.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirtName { get; set; }
        public string LasName { get; set; }
        public string CPF { get; set; }
        public string Office { get; set; }
        public double Salary { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }
        public GenderEnum Gender { get; set; }

        public Employee(string firtName, string lasName, string cPF, string office, double salary, DateTime admissionDate, DateTime resignationDate, DateTime birthDate, bool active, GenderEnum gender)
        {
            FirtName = firtName;
            LasName = lasName;
            CPF = cPF;
            Office = office;
            Salary = salary;
            AdmissionDate = admissionDate;
            ResignationDate = resignationDate;
            BirthDate = birthDate;
            Active = active;
            Gender = gender;
        }

        public Employee()
        {
        }
    }
}
