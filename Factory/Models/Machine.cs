using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntitiesEngineer = new HashSet<EngineerMachine>();
    }
    public int MachineId {get; set; }
    public string Name {get; set; } 
    public string Description { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
    public DateTime InstallationDate {get; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
    public DateTime InspectionDate { get; set; }

    public bool Operational { get; set; } = false;
    public bool Malfunctioning { get; set; } = false;
    public bool UnderRepair { get; set; } = false;

    public virtual ICollection<EngineerMachine> JoinEntitiesEngineer { get; }
  }
}