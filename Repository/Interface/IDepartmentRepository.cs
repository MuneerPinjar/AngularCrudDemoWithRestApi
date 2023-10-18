using AngularCrudDemoWithRestApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrudDemoWithRestApi.Repository.Interface
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartment();
        Task<Department> GetDepartmentByID(int ID);
        Task<Department> InsertDepartment(Department objDepartment);
        Task<Department> UpdateDepartment(Department objDepartment);
        bool DeleteDepartment(int ID);
    }
}
