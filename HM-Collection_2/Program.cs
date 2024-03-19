using HM_Collection_2;

namespace HM_Collection_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Region> regions = new List<Region>();

            Region region1 = new Region
            {
                RegionId = 1,
                RegionName = "North America"
            };
            regions.Add(region1);

            Region region2 = new Region
            {
                RegionId = 2,
                RegionName = "Europe"
            };
            regions.Add(region2);

            Region region3 = new Region
            {
                RegionId = 3,
                RegionName = "Asia"
            };
            regions.Add(region3);

            Region region4 = new Region
            {
                RegionId = 4,
                RegionName = "South America"
            };
            regions.Add(region4);

            Region region5 = new Region
            {
                RegionId = 5,
                RegionName = "Africa"
            };
            regions.Add(region5);

            Region region6 = new Region
            {
                RegionId = 6,
                RegionName = "Oceania"
            };
            regions.Add(region6);

            Region region7 = new Region
            {
                RegionId = 7,
                RegionName = "Middle East"
            };
            regions.Add(region7);

            Region region8 = new Region
            {
                RegionId = 8,
                RegionName = "Central America"
            };
            regions.Add(region8);

            Region region9 = new Region
            {
                RegionId = 9,
                RegionName = "Caribbean"
            };
            regions.Add(region9);

            Region region10 = new Region
            {
                RegionId = 10,
                RegionName = "Antarctica"
            };
            regions.Add(region10);

            List<Country> countries = new List<Country>();
            Country country1 = new Country
            (
                "US",
                "United States",
                region1
            );
            countries.Add(country1);

            Country country2 = new Country
            (
                "CA",
                "Canada",
                region1
            );
            countries.Add(country2);

            Country country3 = new Country
            (
                "UK",
                "United Kingdom",
                region2
            );
            countries.Add(country3);

            Country country4 = new Country
            (
                "FR",
                "France",
                region2
            );
            countries.Add(country4);

            Country country5 = new Country
            (
                "JP",
                "Japan",
                region3
            );
            countries.Add(country5);

            Country country6 = new Country
            (
                "AU",
                "Australia",
                region2
            );
            countries.Add(country6);

            Country country7 = new Country
            (
                "CN",
                "China",
                region3
            );
            countries.Add(country7);

            Country country8 = new Country
            (
                "BR",
                "Brazil",
                region4
            );
            countries.Add(country8);

            Country country9 = new Country
            (
                "ZA",
                "South Africa",
                region5
            );
            countries.Add(country9);

            Country country10 = new Country
            (
                "RU",
                "Russia",
                region2
            );
            countries.Add(country10);

            List<Location> locations = new List<Location>();

            Location location1 = new Location
            {
                LocationId = 1,
                StreetAddress = "123 Main St",
                PostalCode = "12345",
                City = "City 1",
                StateProvince = "State 1",
                Country = country1
            };
            locations.Add(location1);

            Location location2 = new Location
            {
                LocationId = 2,
                StreetAddress = "456 Elm St",
                PostalCode = "54321",
                City = "City 2",
                StateProvince = "State 2",
                Country = country2
            };
            locations.Add(location2);

            Location location3 = new Location
            {
                LocationId = 3,
                StreetAddress = "789 Oak St",
                PostalCode = "67890",
                City = "City 3",
                StateProvince = "State 3",
                Country = country3
            };
            locations.Add(location3);

            Location location4 = new Location
            {
                LocationId = 4,
                StreetAddress = "101 Pine St",
                PostalCode = "11111",
                City = "City 4",
                StateProvince = "State 4",
                Country = country4
            };
            locations.Add(location4);

            Location location5 = new Location
            {
                LocationId = 5,
                StreetAddress = "202 Cedar St",
                PostalCode = "22222",
                City = "City 5",
                StateProvince = "State 5",
                Country = country5
            };
            locations.Add(location5);

            Location location6 = new Location
            {
                LocationId = 6,
                StreetAddress = "303 Birch St",
                PostalCode = "33333",
                City = "City 6",
                StateProvince = "State 6",
                Country = country6
            };
            locations.Add(location6);

            Location location7 = new Location
            {
                LocationId = 7,
                StreetAddress = "404 Pine St",
                PostalCode = "44444",
                City = "City 7",
                StateProvince = "State 7",
                Country = country7
            };
            locations.Add(location7);

            Location location8 = new Location
            {
                LocationId = 8,
                StreetAddress = "505 Maple St",
                PostalCode = "55555",
                City = "City 8",
                StateProvince = "State 8",
                Country = country8
            };
            locations.Add(location8);

            Location location9 = new Location
            {
                LocationId = 9,
                StreetAddress = "606 Oak St",
                PostalCode = "66666",
                City = "City 9",
                StateProvince = "State 9",
                Country = country9
            };
            locations.Add(location9);

            Location location10 = new Location
            {
                LocationId = 10,
                StreetAddress = "707 Elm St",
                PostalCode = "77777",
                City = "City 10",
                StateProvince = "State 10",
                Country = country10
            };
            locations.Add(location10);


            List<Department> departments = new List<Department>();

            Department department1 = new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                LocationId = location1.LocationId
            };
            departments.Add(department1);

            Department department2 = new Department
            {
                DepartmentId = 2,
                DepartmentName = "Sales",
                LocationId = location2.LocationId
            };
            departments.Add(department2);

            Department department3 = new Department
            {
                DepartmentId = 3,
                DepartmentName = "Finance",
                LocationId = location3.LocationId
            };
            departments.Add(department3);

            Department department4 = new Department
            {
                DepartmentId = 4,
                DepartmentName = "Marketing",
                LocationId = location4.LocationId
            };
            departments.Add(department4);

            Department department5 = new Department
            {
                DepartmentId = 5,
                DepartmentName = "IT",
                LocationId = location5.LocationId
            };
            departments.Add(department5);

            Department department6 = new Department
            {
                DepartmentId = 6,
                DepartmentName = "Operations",
                LocationId = location6.LocationId
            };
            departments.Add(department6);

            Department department7 = new Department
            {
                DepartmentId = 7,
                DepartmentName = "Customer Service",
                LocationId = location7.LocationId
            };
            departments.Add(department7);

            Department department8 = new Department
            {
                DepartmentId = 8,
                DepartmentName = "Research and Development",
                LocationId = location8.LocationId
            };
            departments.Add(department8);

            Department department9 = new Department
            {
                DepartmentId = 9,
                DepartmentName = "Quality Control",
                LocationId = location9.LocationId
            };
            departments.Add(department9);

            Department department10 = new Department
            {
                DepartmentId = 10,
                DepartmentName = "Logistics",
                LocationId = location10.LocationId
            };
            departments.Add(department10);


            List<Job> jobs = new List<Job>();

            Job job1 = new Job
            {
                JobId = "Manager",
                JobTitle = "Manager",
                MinSalary = 50000,
                MaxSalary = 80000
            };
            jobs.Add(job1);

            Job job2 = new Job
            {
                JobId = "SalesRep",
                JobTitle = "Sales Representative",
                MinSalary = 30000,
                MaxSalary = 60000
            };
            jobs.Add(job2);

            Job job3 = new Job
            {
                JobId = "Accountant",
                JobTitle = "Accountant",
                MinSalary = 40000,
                MaxSalary = 70000
            };
            jobs.Add(job3);

            Job job4 = new Job
            {
                JobId = "Engineer",
                JobTitle = "Software Engineer",
                MinSalary = 60000,
                MaxSalary = 100000
            };
            jobs.Add(job4);

            Job job5 = new Job
            {
                JobId = "Analyst",
                JobTitle = "Business Analyst",
                MinSalary = 45000,
                MaxSalary = 80000
            };
            jobs.Add(job5);

            Job job6 = new Job
            {
                JobId = "Designer",
                JobTitle = "Graphic Designer",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job6);

            Job job7 = new Job
            {
                JobId = "Assistant",
                JobTitle = "Administrative Assistant",
                MinSalary = 30000,
                MaxSalary = 50000
            };
            jobs.Add(job7);

            Job job8 = new Job
            {
                JobId = "Clerk",
                JobTitle = "Office Clerk",
                MinSalary = 25000,
                MaxSalary = 40000
            };
            jobs.Add(job8);

            Job job9 = new Job
            {
                JobId = "Supervisor",
                JobTitle = "Supervisor",
                MinSalary = 45000,
                MaxSalary = 75000
            };
            jobs.Add(job9);

            Job job10 = new Job
            {
                JobId = "Technician",
                JobTitle = "Maintenance Technician",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job10);

            List<JobHistory> jobHistories = new List<JobHistory>();

            JobHistory jobHistory1 = new JobHistory
            {
                EmployeeId = 1,
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2021, 6, 30),
                JobId = job1.JobId,
                DepartmentId = department1.DepartmentId
            };
            jobHistories.Add(jobHistory1);

            JobHistory jobHistory2 = new JobHistory
            {
                EmployeeId = 2,
                StartDate = new DateTime(2019, 5, 1),
                EndDate = new DateTime(2020, 12, 31),
                JobId = job2.JobId,
                DepartmentId = department2.DepartmentId
            };
            jobHistories.Add(jobHistory2);

            JobHistory jobHistory3 = new JobHistory
            {
                EmployeeId = 3,
                StartDate = new DateTime(2020, 3, 15),
                EndDate = new DateTime(2022, 2, 28),
                JobId = job3.JobId,
                DepartmentId = department3.DepartmentId
            };
            jobHistories.Add(jobHistory3);

            JobHistory jobHistory4 = new JobHistory
            {
                EmployeeId = 4,
                StartDate = new DateTime(2018, 7, 1),
                EndDate = new DateTime(2020, 4, 30),
                JobId = job4.JobId,
                DepartmentId = department4.DepartmentId
            };
            jobHistories.Add(jobHistory4);

            JobHistory jobHistory5 = new JobHistory
            {
                EmployeeId = 5,
                StartDate = new DateTime(2019, 10, 1),
                EndDate = new DateTime(2021, 9, 30),
                JobId = job5.JobId,
                DepartmentId = department5.DepartmentId
            };
            jobHistories.Add(jobHistory5);

            JobHistory jobHistory6 = new JobHistory
            {
                EmployeeId = 6,
                StartDate = new DateTime(2019, 2, 15),
                EndDate = new DateTime(2020, 8, 31),
                JobId = job6.JobId,
                DepartmentId = department6.DepartmentId
            };
            jobHistories.Add(jobHistory6);

            JobHistory jobHistory7 = new JobHistory
            {
                EmployeeId = 7,
                StartDate = new DateTime(2020, 8, 1),
                EndDate = new DateTime(2021, 12, 31),
                JobId = job7.JobId,
                DepartmentId = department7.DepartmentId
            };
            jobHistories.Add(jobHistory7);

            JobHistory jobHistory8 = new JobHistory
            {
                EmployeeId = 8,
                StartDate = new DateTime(2018, 4, 1),
                EndDate = new DateTime(2019, 10, 31),
                JobId = job8.JobId,
                DepartmentId = department8.DepartmentId
            };
            jobHistories.Add(jobHistory8);

            JobHistory jobHistory9 = new JobHistory
            {
                EmployeeId = 9,
                StartDate = new DateTime(2019, 11, 1),
                EndDate = new DateTime(2021, 7, 31),
                JobId = job9.JobId,
                DepartmentId = department9.DepartmentId
            };
            jobHistories.Add(jobHistory9);

            JobHistory jobHistory10 = new JobHistory
            {
                EmployeeId = 10,
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2022, 6, 30),
                JobId = job10.JobId,
                DepartmentId = department10.DepartmentId
            };
            jobHistories.Add(jobHistory10);


            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "555-123-4567",
                HireDate = new DateTime(2020, 1, 15),
                JobId = job1.JobId,
                Salary = 65000,
                CommissionPct = 0.1M,
                ManagerId = 0,
                DepartmentId = department1.DepartmentId,
                RegionId = region1.RegionId,
            };
            employees.Add(employee1);

            Employee employee2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                PhoneNumber = "555-234-5678",
                HireDate = new DateTime(2019, 5, 20),
                JobId = job2.JobId,
                Salary = 55000,
                CommissionPct = 0.08M,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department2.DepartmentId,
                RegionId = region2.RegionId,
            };
            employees.Add(employee2);

            Employee employee3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@example.com",
                PhoneNumber = "555-345-6789",
                HireDate = new DateTime(2021, 3, 10),
                JobId = job3.JobId,
                Salary = 60000,
                CommissionPct = 0.09M,
                ManagerId = 0,
                DepartmentId = department3.DepartmentId,
                RegionId = region3.RegionId,
            };
            employees.Add(employee3);

            Employee employee4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Emily",
                LastName = "Wilson",
                Email = "emily.wilson@example.com",
                PhoneNumber = "555-456-7890",
                HireDate = new DateTime(2018, 7, 5),
                JobId = job4.JobId,
                Salary = 75000,
                CommissionPct = 0.12M,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department4.DepartmentId,
                RegionId = region4.RegionId
            };
            employees.Add(employee4);

            Employee employee5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "David",
                LastName = "Brown",
                Email = "david.brown@example.com",
                PhoneNumber = "555-567-8901",
                HireDate = new DateTime(2019, 10, 3),
                JobId = job5.JobId,
                Salary = 60000,
                CommissionPct = 0.1M,
                ManagerId = 2, // Указываем ID менеджера (employee2)
                DepartmentId = department5.DepartmentId,
                RegionId = region5.RegionId
            };
            employees.Add(employee5);

            Employee employee6 = new Employee
            {
                EmployeeId = 6,
                FirstName = "Sarah",
                LastName = "Davis",
                Email = "sarah.davis@example.com",
                PhoneNumber = "555-678-9012",
                HireDate = new DateTime(2020, 2, 20),
                JobId = job6.JobId,
                Salary = 50000,
                CommissionPct = 0.07M,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department5.DepartmentId,
                RegionId = region5.RegionId
            };
            employees.Add(employee6);

            Employee employee7 = new Employee
            {
                EmployeeId = 7,
                FirstName = "James",
                LastName = "Clark",
                Email = "james.clark@example.com",
                PhoneNumber = "555-789-0123",
                HireDate = new DateTime(2021, 8, 10),
                JobId = job7.JobId,
                Salary = 45000,
                CommissionPct = 0.06M,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department7.DepartmentId,
                RegionId = region7.RegionId
            };
            employees.Add(employee7);

            Employee employee8 = new Employee
            {
                EmployeeId = 8,
                FirstName = "Linda",
                LastName = "Martinez",
                Email = "linda.martinez@example.com",
                PhoneNumber = "555-890-1234",
                HireDate = new DateTime(2018, 4, 15),
                JobId = job8.JobId,
                Salary = 40000,
                CommissionPct = 0.05M,
                ManagerId = 4, // Указываем ID менеджера (employee4)
                DepartmentId = department8.DepartmentId,
                RegionId = region8.RegionId
            };
            employees.Add(employee8);

            Employee employee9 = new Employee
            {
                EmployeeId = 9,
                FirstName = "Kevin",
                LastName = "Harris",
                Email = "kevin.harris@example.com",
                PhoneNumber = "555-901-2345",
                HireDate = new DateTime(2019, 11, 5),
                JobId = job9.JobId,
                Salary = 52000,
                CommissionPct = 0.08M,
                ManagerId = 5, // Указываем ID менеджера (employee5)
                DepartmentId = department3.DepartmentId,
                RegionId = region3.RegionId
            };
            employees.Add(employee9);

            Employee employee10 = new Employee
            {
                EmployeeId = 10,
                FirstName = "Laura",
                LastName = "Young",
                Email = "laura.young@example.com",
                PhoneNumber = "555-012-3456",
                HireDate = new DateTime(2020, 7, 1),
                JobId = job10.JobId,
                Salary = 48000,
                CommissionPct = 0.07M,
                ManagerId = 7, // Указываем ID менеджера (employee7)
                DepartmentId = department3.DepartmentId,
                RegionId = region3.RegionId
            };
            employees.Add(employee10);

            /////////////////////////////////////////////////////////////////////////////////////////////////
            // #1. Найти самого высокооплачиваемого сотрудника: Найдите сотрудника с самой высокой зарплатой в коллекции employees.

            // 1 вариант
            Employee employee = employees[0];
            decimal maxSalary = employees[0].Salary;           
            foreach (var item in employees)
            {
                if (item.Salary > maxSalary)
                {
                    employee = item;
                    maxSalary = item.Salary;
                }
            }
            Console.WriteLine($"#1. Найти самого высокооплачиваемого сотрудника: {employee}");
            // 2 вариант
            Console.WriteLine("#1. Найдите сотрудника с самой высокой зарплатой в коллекции employees: " + employees.Find(employee => employee.Salary == employees.Max(x => x.Salary)));

            // #2. Обновление информации о регионе сотрудника: Найдите сотрудника в коллекции employees, и обновите информацию о его регионе.
            Console.WriteLine(regions[0].RegionName);
            (regions.Find(region => region.RegionId == employees[0].RegionId)).RegionName = "Avstralia";

            Console.WriteLine(regions[0].RegionName);

            // #3. Найти отдел с максимальным числом сотрудников:

            Dictionary<int, int> idDepCount = new Dictionary<int, int>();
            foreach (var item in employees)
            {
                if (idDepCount.ContainsKey(item.DepartmentId))
                {
                    idDepCount[item.DepartmentId] += 1;
                    continue;
                }
                idDepCount.Add(item.DepartmentId, 1);
            }
            int maxVal = 0;
            int idDep = 0;
            foreach (var pair in idDepCount)
            {
                if (pair.Value > maxVal) 
                { 
                    idDep = pair.Key;
                    maxVal = pair.Value;
                }
            }
            Console.WriteLine($"#5. Найти отдел с максимальным числом сотрудников: {departments.Find(department => department.DepartmentId == idDep)}");
        }
    }
}
