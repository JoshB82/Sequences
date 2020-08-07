namespace Sequences
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sequence_Names = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sequence_Finish = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Sequence_Start = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_Text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence_Finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // Sequence_Names
            // 
            this.Sequence_Names.FormattingEnabled = true;
            this.Sequence_Names.Items.AddRange(new object[] {
            "Fibonacci numbers",
            "Prime numbers"});
            this.Sequence_Names.Location = new System.Drawing.Point(149, 13);
            this.Sequence_Names.Name = "Sequence_Names";
            this.Sequence_Names.Size = new System.Drawing.Size(151, 28);
            this.Sequence_Names.TabIndex = 0;
            this.Sequence_Names.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a sequence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sequence_Finish);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sequence_Start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Term Number";
            // 
            // Sequence_Finish
            // 
            this.Sequence_Finish.Location = new System.Drawing.Point(154, 29);
            this.Sequence_Finish.Name = "Sequence_Finish";
            this.Sequence_Finish.Size = new System.Drawing.Size(65, 27);
            this.Sequence_Finish.TabIndex = 8;
            this.Sequence_Finish.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Sequence_Finish.ValueChanged += new System.EventHandler(this.Sequence_Finish_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "From:";
            // 
            // Sequence_Start
            // 
            this.Sequence_Start.Location = new System.Drawing.Point(60, 30);
            this.Sequence_Start.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Sequence_Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sequence_Start.Name = "Sequence_Start";
            this.Sequence_Start.Size = new System.Drawing.Size(58, 27);
            this.Sequence_Start.TabIndex = 6;
            this.Sequence_Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sequence_Start.ValueChanged += new System.EventHandler(this.Sequence_Start_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // Result_Text
            // 
            this.Result_Text.AutoSize = true;
            this.Result_Text.Location = new System.Drawing.Point(21, 189);
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.Size = new System.Drawing.Size(49, 20);
            this.Result_Text.TabIndex = 6;
            this.Result_Text.Text = "Result";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 250);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sequence_Names);
            this.Name = "Main";
            this.Text = "Sequences";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence_Finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence_Start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Sequence_Names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Sequence_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Sequence_Finish;
        private System.Windows.Forms.Label Result_Text;
    }
}

