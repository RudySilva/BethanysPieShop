using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Lorem ipsum dolor sit amet consectetuer", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
                new Pie {Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "Lorem ipsum dolor sit amet consectetuer", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
                new Pie {Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Lorem ipsum dolor sit amet consectetuer", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
                new Pie {Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "Lorem ipsum dolor sit amet consectetuer", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},

            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
