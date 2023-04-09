namespace ConsoleUI.Models
{
    public class Homework : IModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }

        public override string ToString()
        {
            return $"[red]Başlık:[/] {Title} [red]Açıklama:[/] {Description} [red]Son Teslim:[/] {DueDate}";
        }
    }
}
