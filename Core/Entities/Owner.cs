namespace Core.Entities;

public class Owner : EntityBase{
    public String fullName { get; set; }
    public String Profile { get; set; }
    public String Avatar { get; set; }
    public Address Address { get; set; }
}