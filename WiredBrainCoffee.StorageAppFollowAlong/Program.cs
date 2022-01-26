using System;
using WiredBrainCoffee.StorageAppFollowAlong.Entities;
using WiredBrainCoffee.StorageAppFollowAlong.Repositories;

namespace WiredBrainCoffee.StorageAppFollowAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();


            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "PluralSight" });
            organizationRepository.Add(new Organization { Name = "GlobalMantics" });
            organizationRepository.Save();



            Console.ReadLine();


        }
    }
}
