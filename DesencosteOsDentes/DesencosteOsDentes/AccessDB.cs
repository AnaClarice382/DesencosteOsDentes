using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesencosteOsDentes
{
  public class AccessDB
  {
    public void Insert(Occurrence occurrence)
    {
      using (var db = new LiteDatabase(System.Configuration.ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString))
      {
        var col = db.GetCollection<Occurrence>("occurrences");

        // Insert new occurrence document (Id will be auto-incremented)
        col.Insert(occurrence);
      }
    }
    public void UpdateConfig()
    {
      using (var db = new LiteDatabase(System.Configuration.ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString))
      {
        var col = db.GetCollection<Occurrence>("customers");

        var occurrence = new Occurrence
        {

        };
        col.Update(occurrence);
      }
    }
    public Dictionary<int, DateTime> SelectAll()
    {
      Dictionary<int, DateTime> a = new Dictionary<int, DateTime>();

      using (var db = new LiteDatabase(System.Configuration.ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString))
      {
        var col = db.GetCollection<Occurrence>("occurrences");

        foreach (Occurrence item in col.FindAll())
          a.Add(item.PainLevel, item.DtOccurrence);
      }
      return a;
    }
  }
}

