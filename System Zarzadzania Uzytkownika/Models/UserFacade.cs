using UserManagement.Models;  // Upewnij się, że ta przestrzeń nazw jest poprawna
using System;  // Jeśli chcesz korzystać z ogólnych metod C#

public class UserFacade
{
    private readonly UserRepository _userRepository;

    public UserFacade()
    {
        _userRepository = new UserRepository();
    }

    public void AddUser(User user)
    {
        _userRepository.Add(user);
    }

    public void UpdateUser(User user)
    {
        _userRepository.Update(user);
    }

    public void DeleteUser(int userId)
    {
        _userRepository.Delete(userId);
    }
}
