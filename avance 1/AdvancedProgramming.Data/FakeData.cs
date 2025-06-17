using AdvancedProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.Data
{
    public class FakeData
    {
        public IEnumerable<Fruit> CreateFruit(string name)
        {
            var fruits = new List<Fruit>();
            for (int i = 0; i < 1000; i++)
            {
                fruits.Add(new Fruit
                {
                    Id = i+1,
                    Name = $"{name}-{i+1}",
                    Calories = i+5*10/2,
                    Weight = i+5*10/2^2,
                });
            }

            return fruits;
        }
    }
}
