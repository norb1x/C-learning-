namespace UserManagement.Services
{
    public class AuthenticationService
    {
        public bool Authenticate(string email, string password)
        {
            // Przykładowa autoryzacja
            return email == "admin@example.com" && password == "admin123";
        }
    }
}
