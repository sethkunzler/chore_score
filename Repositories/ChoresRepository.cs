
namespace chore_score.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;
  public ChoresRepository(IDbConnection db)
  {
    _db = db; 
  }

  public List<Chore> GetChores()
  {
    string sql = "SELECT * FROM cats;";

    List<Chore> chores = _db.Query<Chore>(sql).ToList();

    return chores;
  }

  internal Chore CreateChore(Chore choreData)
  {
    // string badSql = @$"
    // INSERT INTO 
    // chores(difficulty, isDone, color, isUrgent, name)
    // VALUES({choreData.Difficultly}, {choreData.IsDone}, '{choreData.Color}', {choreData.IsUrgent}, '{choreData.Name}');

    // SELECT * FROM chores WHERE id = LAST_INSERT_ID()
    // ";

    string goodSql = @"
    chores(difficulty, isDone, color, isUrgent, name)
    VALUES(@Difficulty, @IsDone, @Color, @IsUrgent, @Name)
    
    SELECT * FROM chores WHERE id = LAST_INSERT_ID()
    ";

    Chore chore = _db.Query<Chore>(goodSql, choreData).FirstOrDefault();
    return chore;
  }

}