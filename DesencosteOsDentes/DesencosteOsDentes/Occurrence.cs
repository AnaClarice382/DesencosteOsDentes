using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesencosteOsDentes
{
  public class Occurrence
  {
    [BsonId]
    public Guid Id { get; set; }
    public DateTime DtOccurrence { get; set; }
    public bool IsActive { get; set; }
    public int PainLevel { get; set; }
  }

  public enum PainLevelEnum
  {
    NoPain = 0,
    MildPain = 1,
    ModeratePain = 4,
    SeverePain = 7
  }
}
