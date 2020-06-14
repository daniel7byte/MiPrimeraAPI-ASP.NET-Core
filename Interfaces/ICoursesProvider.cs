using MiPrimeraAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiPrimeraAPI.Interfaces
{
    public interface ICoursesProvider
  {
    Task<ICollection<Course>> GetAllAsync();

    Task<ICollection<Course>> SearchAsync(string search);

    Task<Course> GetAsync(int id);

    Task<bool> UpdateAsync(int id, Course course);

    Task<(bool IsSucces, int? Id)> AddAsync(Course course);
  }
}
