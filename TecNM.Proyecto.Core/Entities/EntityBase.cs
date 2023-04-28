namespace TecNM.Proyecto.Core.Entities;


public class EntityBase
{
    public int Id { get; set; } 
    public bool IsDeleted { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdateDate { get; set; }
}

public class Test1 : EntityBase
{


}