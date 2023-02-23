using Domain;
using Domain.DTOs;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(RegisterDto registerDto);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
    Task DeleteAsync(int id);
}