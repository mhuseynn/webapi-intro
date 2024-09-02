using WebApiIntro.Entities.Concretes;
using WebApiIntro.Reposiotries.Abstracts;

namespace WebApiIntro.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddUser(User user)
    {
        await _userRepository.AddAsync(user);
        await _userRepository.SaveAllChangesAsync();
    }

    public async Task UpdateUser(User user)
    {
        await _userRepository.UpdateAsync(user);
        await _userRepository.SaveAllChangesAsync();
    }

    public async Task DeleteUser(int id)
    {
        await _userRepository.DeleteAsync(id);
        await _userRepository.SaveAllChangesAsync();
    }

    public async Task<User?> GetUser(int id)
    {
        return await _userRepository.GetAsync(id);
    }

    public async Task<IQueryable<User>> GetAllUsers()
    {
        return await _userRepository.GetAllAsync();
    }
}