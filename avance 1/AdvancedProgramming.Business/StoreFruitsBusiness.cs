using AdvancedProgramming.Data;
using AdvancedProgramming.Models;
using AdvancedProgramming.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.Business
{
    public class StoreFruitsBusiness
    {
        private readonly FakeData fakeData;
        public StoreFruitsBusiness()
        {
            fakeData = new FakeData();
        }
        public IEnumerable<Fruit> FillStore()
        {
            var fruits = new List<Fruit>();
            fruits.AddRange(fakeData.CreateFruit("apple"));
            fruits.AddRange(fakeData.CreateFruit("banana"));
            fruits.AddRange(fakeData.CreateFruit("orange"));

            return fruits;           
        }    
    }
}
