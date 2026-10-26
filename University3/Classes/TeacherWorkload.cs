using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace University3.Classes;

public class TeacherWorkload
{
    [Key]
    public int Id { get; private set; }
    
    [ForeignKey("Teacher")]
    public int TeacherId { get; private set; }
    public Teacher Teacher { get; private set; }
    
    [ForeignKey("Discipline")]
    public int DisciplineId { get; private set; }
    public Discipline Discipline { get; private set; }
    
    [ForeignKey("Roles")]
    public int RoleId { get;  private set; }
    public Roles Roles { get;  private set; }
    
    public int QuantityOfHours {get; private set; }

    public TeacherWorkload(int id, int teacherId,
        int disciplineId, int roleId, int quantityOfHours)
    {
        Id = id;
        TeacherId = teacherId;
        DisciplineId = disciplineId;
        RoleId = roleId;
        QuantityOfHours = quantityOfHours;
        
    }
}