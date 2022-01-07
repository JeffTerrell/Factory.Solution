using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntitiesMachine = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
    public DateTime LicenseRenewalDates {get; set;}

    public bool Active { get; set; } = false;
    public bool Idle { get; set; } = false;
    public virtual ICollection<EngineerMachine> JoinEntitiesMachine { get; set; }
  }
}