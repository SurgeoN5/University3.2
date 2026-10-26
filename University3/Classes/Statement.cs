using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University3.Classes;

public class Statement
{
    //ведомость еб
    [Key]
    public int Id { get;private set; }
    
    [ForeignKey("Students")]
    public int StudentId { get;private set; }
    public Students Students { get;private set; }
    
    [ForeignKey("Discipline")]
    public int DisciplineId { get;private set; }
    public Discipline Discipline { get;private set; }
    
    [ForeignKey("Semestr")]
    public int SemesterId { get;private set; }
    public Semestr Semestr { get;private set; }
    
    public bool Grants { get;private set; }
    
    public bool NextCourse { get;private set; }
    
    public decimal AverageScore { get;private set; }


    public Statement(int id, int studentId, int disciplineId, bool grants, bool nextCourse
    ,int semesterId, decimal averageScore)
    {
        Id = id;
        StudentId = studentId;
        DisciplineId = disciplineId;
        Grants = grants;
        NextCourse = nextCourse;
        SemesterId = semesterId;
        AverageScore = averageScore;
    }
}

