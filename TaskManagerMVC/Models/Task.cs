namespace TaskManagerMVC.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public string Priorytet { get; set; }
        public string Uzytkownik { get; set; }
    }
}