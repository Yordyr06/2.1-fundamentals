namespace Fundamentals.Repositories
{
  public interface IDate 
  {
    public string Date { get; set; }
    public Workday Workday { get; set; }
    public Schedule Schedule { get; set; }
  }
}