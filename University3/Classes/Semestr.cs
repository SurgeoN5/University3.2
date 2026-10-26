using System.ComponentModel.DataAnnotations;

namespace University3.Classes;

public class Semestr
{
    [Key]
    public int Id { get;  private set; }
    
    public string Name { get;  private set; }
    
    public DateTime StartDate { get;  private set; }
    public DateTime EndDate { get;  private set; }
    
    public Semestr(int  id, string name, DateTime startDate, DateTime endDate)
    {
        Id = id;
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
    }
}