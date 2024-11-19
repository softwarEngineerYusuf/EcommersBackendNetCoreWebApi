using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : class  //  where T : class bu ifade kesinlikle class vereceğimizi bildirmeye yarıyor.
    {
        // Tüm kayıtları getirir
        Task<IEnumerable<T>> GetAllAsync();

        // Şartlı sorgu için
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task<T> FindSingleAsync(Expression<Func<T, bool>> predicate);

        // Id ile bir kayıt getirir
        Task<T> GetByIdAsync(Guid id);

        // Ekleme işlemleri
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities); // Liste için daha uygun isimlendirme

        // Güncelleme işlemleri
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);

        // Silme işlemleri
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync(Guid id);
        Task RemoveRangeAsync(IEnumerable<T> entities);

        // Değişiklikleri kaydet
        Task<bool> SaveChangesAsync(); // Eğer UnitOfWork yoksa kullanılabilir
    }
}
