namespace PerformWithItems.Models;

public class TheItem(int id)
{
    public int Id { get; set; } = id;
    public DateTime Date { get; set; } = DateTime.Now.AddDays(Random.Shared.Next(-200, 200));
    public string Text { get; set; } = Guid.NewGuid().ToString();
    public double Value { get; set; } = Random.Shared.Next(0, 2_000);
}
