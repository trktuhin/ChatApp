namespace WebAPI.models;

public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastModifiedOn { get; set; }
}
