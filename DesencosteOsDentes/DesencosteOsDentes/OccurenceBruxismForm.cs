using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesencosteOsDentes
{
  public partial class OccurenceBruxismForm : Form
  {
    Occurrence occurrence = null;

    public OccurenceBruxismForm()
    {
      InitializeComponent();
      panel2.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      occurrence = new Occurrence();
      occurrence.IsActive = true;
      occurrence.DtOccurrence = DateTime.Now;

      ControlPanel();

    }

    private void ControlPanel()
    {
      panel1.Visible = false;
      panel2.Visible = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      occurrence = new Occurrence();
      occurrence.IsActive = false;
      occurrence.DtOccurrence = DateTime.Now;

      ControlPanel();
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton4.Checked)
      {
        occurrence.PainLevel = 7; //PainLevelEnum.SeverePain;
      }
      PrepareInsert();
    }

    private void PrepareInsert()
    {
      AccessDB db = new AccessDB();
      db.Insert(occurrence);

      this.Close();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton1.Checked)
      {
        occurrence.PainLevel = 0; //PainLevelEnum.NoPain;
      }
      PrepareInsert();
    }
    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton3.Checked)
      {
        occurrence.PainLevel = 4; //PainLevelEnum.ModeratePain;
      }
      PrepareInsert();
    }
    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton2.Checked)
      {
        occurrence.PainLevel = 1; //PainLevelEnum.MildPain;
      }
      PrepareInsert();
    }
  }
}
