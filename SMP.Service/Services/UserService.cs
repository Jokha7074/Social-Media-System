using AutoMapper;
using SMP.Data.Entities;
using SMP.Data.IRepositories;
using SMP.Domain.Security;
using SMP.Service.DTOs.Users;
using SMP.Service.Exceptions;
using SMP.Service.Helpers;
using SMP.Service.IRepositories;

namespace SMP.Service.Services;

public class UserService : IUserService
{
    public IMapper mapper;
    public IRepository<User> repository;
    public UserService(IRepository<User> repository)
    {
        this.mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()));
        this.repository = repository;
    }

    public async Task<UserResultDto> AddAsync(UserCreateDto dto)
    {
        var existUser = await repository.GetAsync(x => x.Email == dto.Email && x.IsDeleted == false);
        if (existUser is not null)
            throw new AlreadyExistException("This user allready exist");

        var hashSalt = PasswordHash.Hasher(dto.PasswordHash);

        var user = mapper.Map<User>(dto);

        user.Salt = hashSalt.Salt;
        user.PasswordHash = hashSalt.Passwordhash;

        await repository.CreateAsync(user);
        await repository.SaveAsync();

        var result = mapper.Map<UserResultDto>(user);
        return result;
    }

    public async Task<UserResultDto> ModifyAsync(UserUpadeDto dto)
    {
        var user = await repository.GetAsync(x => x.Id == dto.Id && x.IsDeleted == false);
        if (user is null)
            throw new NotFoundException("This user is not found");

        var hashSalt = PasswordHash.Hasher(dto.PasswordHash);

        dto.Salt = hashSalt.Salt;
        dto.PasswordHash = hashSalt.Passwordhash;

        var modifiedUser = mapper.Map(dto, user);
        await repository.SaveAsync();

        var result = mapper.Map<UserResultDto>(user);
        return result;
    }

    public async Task<bool> RemoveAsync(long Id)
    {
        var user = await repository.GetAsync(x => x.Id == Id);
        if (user is null)
            return false;

        repository.Delete(user);
        await repository.SaveAsync();

        return true;
    }

    public IEnumerable<UserResultDto> RetrieveAll()
    {
        var users = repository.GetAll().Where(x => x.IsDeleted == false);

        var resultUsers = mapper.Map<IEnumerable<UserResultDto>>(users);
        return resultUsers;
    }

    public async Task<UserResultDto> RetrieveByIdAsync(long Id)
    {
        var user = await repository.GetAsync(x => x.Id == Id && x.IsDeleted == false);
        if (user is null)
            throw new NotFoundException("This user is not found");

        var result = mapper.Map<UserResultDto>(user);
        return result;
    }
}
