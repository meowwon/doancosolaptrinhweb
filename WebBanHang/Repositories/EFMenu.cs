using Microsoft.EntityFrameworkCore;
using WebBanHang.Models;

namespace WebBanHang.Repositories
{
    public class EFMenu : IMenu
    {
        private readonly ApplicationDbContext _context;
        public EFMenu(ApplicationDbContext context)
        {
            _context = context;
        }
        // Tương tự như EFProductRepository, nhưng cho Category
        public async Task<IEnumerable<MenuCategory>> GetAllAsync()
        {
            // return await _context.Products.ToListAsync();
            return await _context.MenuCategories.Include(p=>p.Categorys).ToListAsync();
        }
        public async Task<MenuCategory> GetByIdAsync(int id)
        {
            // return await _context.Products.FindAsync(id);
            // lấy thông tin kèm theo category
            return await _context.MenuCategories.Include(p => p.Categorys).FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task AddAsync(MenuCategory menucategory)
        {
            _context.MenuCategories.Add(menucategory);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(MenuCategory menucategory)
        {
            _context.MenuCategories.Update(menucategory);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {


            var menucategory = await _context.MenuCategories.FindAsync(id);
            _context.MenuCategories.Remove(menucategory);
            await _context.SaveChangesAsync();
        }



    }
}
