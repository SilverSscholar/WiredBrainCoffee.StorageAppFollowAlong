using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageAppFollowAlong.Entities;

namespace WiredBrainCoffee.StorageAppFollowAlong.Repositories
{
    public class Employee_Repository
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Save()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}

    

