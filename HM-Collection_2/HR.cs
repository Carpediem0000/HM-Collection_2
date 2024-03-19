using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Collection_2
{
    // Базовый класс для регионов
    class Region
    {
        public int RegionId { get; set; }     // Идентификатор региона
        public string RegionName { get; set; } // Название региона
    }

    // Класс для стран, наследуется от Region
    class Country : Region
    {
        public string CountryId { get; set; }   // Идентификатор страны
        public string CountryName { get; set; } // Название страны

        public Country(string countryId, string countryName, Region region)
        {
            CountryId = countryId;
            CountryName = countryName;
            RegionId = region.RegionId;
            RegionName = region.RegionName;
        }
    }

    // Класс для локаций
    class Location
    {
        public int LocationId { get; set; }       // Идентификатор локации
        public string StreetAddress { get; set; } // Улица и номер дома
        public string PostalCode { get; set; }    // Почтовый индекс
        public string City { get; set; }          // Город
        public string StateProvince { get; set; } // Провинция или штат
        public Country Country { get; set; }      // Объект страны, связывающий локацию с соответствующей страной
    }

    // Класс для отделов
    class Department
    {
        public int DepartmentId { get; set; }   // Идентификатор отдела
        public string DepartmentName { get; set; } // Название отдела
        public int ManagerId { get; set; }        // Идентификатор менеджера отдела
        public int LocationId { get; set; }       // Идентификатор локации, где расположен отдел
        public override string ToString()
        {
            return $"DepartmentId: {DepartmentId}, DepartmentName: {DepartmentName}";
        }
    }

    // Класс для должностей
    class Job
    {
        public string JobId { get; set; }     // Идентификатор должности
        public string JobTitle { get; set; } // Название должности
        public decimal MinSalary { get; set; } // Минимальная зарплата
        public decimal MaxSalary { get; set; } // Максимальная зарплата
    }

    // Класс для истории должностей
    class JobHistory
    {
        public int EmployeeId { get; set; } // Идентификатор сотрудника
        public DateTime StartDate { get; set; } // Дата начала работы на должности
        public DateTime EndDate { get; set; } // Дата окончания работы на должности
        public string JobId { get; set; } // Идентификатор должности
        public int DepartmentId { get; set; } // Идентификатор отдела
    }

    // Класс для сотрудников
    class Employee
    {
        public int EmployeeId { get; set; }     // Идентификатор сотрудника
        public string FirstName { get; set; }   // Имя сотрудника
        public string LastName { get; set; }    // Фамилия сотрудника
        public string Email { get; set; }       // Адрес электронной почты сотрудника
        public string PhoneNumber { get; set; } // Номер телефона сотрудника
        public DateTime HireDate { get; set; }  // Дата найма сотрудника
        public string JobId { get; set; }       // Идентификатор должности, на которую нанят сотрудник
        public decimal Salary { get; set; }     // Зарплата сотрудника
        public decimal CommissionPct { get; set; } // Процент комиссии сотрудника (если применимо)
        public int ManagerId { get; set; }      // Идентификатор руководителя сотрудника
        public int DepartmentId { get; set; }   // Идентификатор отдела, к которому принадлежит сотрудник
        public int RegionId { get; set; }   // Идентификатор региона, к которому принадлежит сотрудник

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}, Name: {FirstName + " " + LastName}, Salary: {Salary}";
        }
    }
}
