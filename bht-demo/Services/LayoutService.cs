using bht_demo.Controllers;
using bht_demo.DAL;
using bht_demo.Models;
using System.Collections.Generic;
using System.Linq;

namespace bht_demo.Services
{
    public class LayoutService
    {
        private AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }
        public List<BlogCategory> GetBlogCategory()
        {
            return _context.BlogCategories.ToList();
        }
    }
}
