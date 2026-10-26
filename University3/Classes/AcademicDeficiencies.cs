using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University3.Classes;

public class AcademicDeficiencies
{
    [Key]
    public int Id { get; private set; }
    
    [ForeignKey("Students")]
    public int StudentId { get; private set; }
    public Students Students { get; private set; }
    
    [ForeignKey("Statement")]
    public int StatementId { get; private set; }
    public Statement Statement { get; private set; }
    
    public int QuantityOfHourse { get; private set; }
    
    [ForeignKey("Discipline")]
    public int DisciplineId { get; private set; }
    public Discipline Discipline { get; private set; }

    public AcademicDeficiencies(int id, int studentId, int statementId, int quantityOfHourse, int disciplineId)
    {
        Id = id;
        StudentId = studentId;
        StatementId = statementId;
        QuantityOfHourse = quantityOfHourse;
        DisciplineId = disciplineId;
    }
    
}