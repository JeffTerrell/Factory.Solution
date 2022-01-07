namespace Factory.Models
{
  public class LocationMachine
  {
    public int LocationMachineId {get; set;}
    public int MachineId {get; set;}
    public int LocationId {get; set;}
    public virtual Location Location {get; set;}
    public virtual Machine Machine {get; set;}
  }
}