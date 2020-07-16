namespace DesencosteOsDentes
{
  partial class OccurenceBruxismForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(89, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(194, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Você estava apertando os dentes?";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(54, 39);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(128, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Sim";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(188, 39);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(132, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Não";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Location = new System.Drawing.Point(2, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(368, 77);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.radioButton4);
      this.panel2.Controls.Add(this.radioButton3);
      this.panel2.Controls.Add(this.radioButton2);
      this.panel2.Controls.Add(this.radioButton1);
      this.panel2.Location = new System.Drawing.Point(2, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(368, 77);
      this.panel2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(114, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(128, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "What is your pain level";
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(265, 39);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(83, 17);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.Text = "Severe Pain";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(165, 39);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(94, 17);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.Text = "Moderate Pain";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(91, 39);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(68, 17);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.Text = "Mild Pain";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(20, 39);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(62, 17);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.Text = "No pain";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // OccurenceBruxismForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 82);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.Name = "OccurenceBruxismForm";
      this.Text = "Relaxe e solte os dentes";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.Label label2;
  }
}