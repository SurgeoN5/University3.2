using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University3.Classes;

public class Discipline
{
    [Key]
    public int Id { get;  private set; }
    
    public string Name { get;  private set; }
    
    [ForeignKey("FormOfReport")]
    public int FormOfReportId { get;  private set; }
    public FormOfReport FormOfReport { get; private set; }

    public Discipline(int id, string name, int formOfReportId)
    {
        Id = id;
        Name = name;
        FormOfReportId = formOfReportId;
    }
    
    
    
}