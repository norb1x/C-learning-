namespace BankManagementApp
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        // Metoda do wyświetlania danych klienta
        public override string ToString()
        {
            return $"ID: {Id}, Imię: {FirstName}, Nazwisko: {LastName}, Saldo: {Balance} PLN";
        }
    }
}
