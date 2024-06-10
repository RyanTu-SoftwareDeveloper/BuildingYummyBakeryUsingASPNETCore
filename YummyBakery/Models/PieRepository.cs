
using Microsoft.EntityFrameworkCore;

namespace YummyBakery.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly YummyBakeryDbContext _yummyBakeryDbContext;
        public PieRepository(YummyBakeryDbContext yummyBakeryDbContext)
        {
            _yummyBakeryDbContext = yummyBakeryDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _yummyBakeryDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _yummyBakeryDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
          return _yummyBakeryDbContext.Pies.FirstOrDefault(p =>p.PieId == pieId);   
        }
    }
}
