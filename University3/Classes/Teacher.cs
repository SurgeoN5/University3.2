using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University3.Classes;

public class Teacher
{
    [Key]
    public int Id { get;  private set; }
    
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    
    [ForeignKey("Discipline")]
    public int DisciplineId { get;  private set; }
    public Discipline Discipline { get;  private set; }
    


    public Teacher(int id, string firstName, string lastName, int disciplineId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;   
        DisciplineId = disciplineId;
    }
}
