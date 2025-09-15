namespace MiDiarioApp.Models
{
    public class Note
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Text { get; set; }
    }
}