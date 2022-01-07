using System.Collections.Generic;

namespace Factory.Models
{
  public class Location
  {
    public Location()
    {
      this.JoinEntitiesMachine = new HashSet<LocationMachine>() ;
      this.JoinEntitiesEngineer = new HashSet<EngineerLocation>();
    }

    public int LocationId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<LocationMachine> JoinEntitiesMachine {get; set;}
    public virtual ICollection<EngineerLocation> JoinEntitiesEngineer {get; set;}
  }
}