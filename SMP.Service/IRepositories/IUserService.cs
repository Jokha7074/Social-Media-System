using SMP.Service.DTOs.Users;

namespace SMP.Service.IRepositories;

public interface IUserService
{
    Task<UserResultDto> AddAsync(UserCreateDto dto);
    Task<UserResultDto> ModifyAsync(UserUpadeDto dto);
    Task<bool> RemoveAsync(long Id);
    Task<UserResultDto> RetrieveByIdAsync(long Id);
    IEnumerable<UserResultDto> RetrieveAll();
}
