using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageAppFollowAlong.Entities;

namespace WiredBrainCoffee.StorageAppFollowAlong.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _itmes = new();

        public void Add(T item)
        {
            _itmes.Add(item);
        }
        public void Save()
        {
            foreach (var item in _itmes)
            {
                Console.WriteLine(item);
            }

        }
    }
}

    

