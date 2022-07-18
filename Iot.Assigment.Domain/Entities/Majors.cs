namespace Iot.Assignment.Domain.Entities;

public class Majors : FullEntityBase<Guid>
{
    public string  Name { get; set; }
    public string  Descreption { get; set; }
}