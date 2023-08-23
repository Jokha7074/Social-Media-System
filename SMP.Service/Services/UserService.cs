using AutoMapper;
using SMP.Data.IRepositories;
using SMP.Service.DTOs.Users;
using SMP.Service.Exceptions;
using SMP.Service.IRepositories;

namespace SMP.Service.Services;

public class UserService : IUserService
{
    public IMapper Mapper;
    public IRepository Repository;
    public UserService()
    {
        
    }
    public Task<UserResultDto> AddAsync(UserCreateDto dto)
    {
        throw new AlreadyExistException("This user allready exist");
    }

    public Task<UserResultDto> ModifiedAsync(UserUpadeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Remove(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> RetriveredById(long Id)
    {
        throw new NotImplementedException();
    }
}
