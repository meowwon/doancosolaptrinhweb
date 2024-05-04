using WebBanHang.Models;

namespace WebBanHang.Repositories
{
    public interface IMenu
    {
        Task<IEnumerable<MenuCategory>> GetAllAsync();
        Task<MenuCategory> GetByIdAsync(int id);
        Task AddAsync(MenuCategory menucategory);
        Task UpdateAsync(MenuCategory menucategory);
        Task DeleteAsync(int id);
    }
}
