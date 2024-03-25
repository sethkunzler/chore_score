// This is a Chore
namespace chore_score.Models; 

public class Chore {
  public int Id { get; set; }
  public string Name { get; set; }
  public int Difficultly { get; set; }
  public string Color { get; set; }
  public bool isDone { get; set; }
  public bool isUrgent { get; set; }
}