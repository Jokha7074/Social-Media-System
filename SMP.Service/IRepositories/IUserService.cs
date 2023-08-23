using SMP.Service.DTOs.Users;

namespace SMP.Service.IRepositories;

public interface IUserService
{
    Task<UserResultDto> AddAsync(UserCreateDto dto);
    Task<UserResultDto> ModifiedAsync(UserUpadeDto dto);
    Task<bool> Remove(long Id);
    Task<UserResultDto> RetriveredById(long Id);
}
