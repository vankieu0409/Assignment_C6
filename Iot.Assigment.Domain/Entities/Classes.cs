namespace Iot.Assignment.Domain.Entities;

public class Classes : FullEntityBase<Guid>
{
    public Guid MajorId { get; set; }
    
    public string Name { get; set; }
    public string Classroom { get; set; }
    public virtual ICollection<Student> Students { get; set; }
}