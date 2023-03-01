using GreenCloud.Store.Application.Dtos;
using GreenCloud.Store.Entity;

namespace GreenCloud.Store.Application.Interfaces
{
    public interface IEmployeesApplication
    {
        Task<List<EmployeeForListDto>> GetEmployees();
        Task<EmployeeDetailDto> GetEmployee(int id);

        Task InsertEmployee(EmployeeForCreateDto employeeForCreateDto);
    }
}
