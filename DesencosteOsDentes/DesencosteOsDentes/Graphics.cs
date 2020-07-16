using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesencosteOsDentes
{
  public partial class Graphics : Form
  {
    public Graphics()
    {
      InitializeComponent();
      InitializeGraphics();
    }

    private void InitializeGraphics()
    {
      AccessDB access = new AccessDB();
      var result = access.SelectAll();

      chart1.DataSource = result;

      var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
      {
        Name = "Desencosta",
        Color = System.Drawing.Color.Green,
        IsVisibleInLegend = true,
        IsXValueIndexed = true,
        ChartType = SeriesChartType.Line
      };

      series1.Points.DataBindXY(result.Values, result.Keys);
      series1.YValueMembers = "PainLevel";
      series1.XValueMember = "DtOccurrence";

      this.chart1.Series.Add(series1);
    }
  }
}
