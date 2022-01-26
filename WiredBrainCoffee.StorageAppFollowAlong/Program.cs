using System;
using WiredBrainCoffee.StorageAppFollowAlong.Entities;
using WiredBrainCoffee.StorageAppFollowAlong.Repositories;

namespace WiredBrainCoffee.StorageAppFollowAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new Employee_Repository();
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();

            Console.ReadLine();


        }
    }
}
