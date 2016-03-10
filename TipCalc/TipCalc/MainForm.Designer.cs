namespace TipCalc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipTrackBar = new System.Windows.Forms.TrackBar();
            this.peopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.tipLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipTrackBarLabel = new System.Windows.Forms.Label();
            this.billErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // billTextBox
            // 
            this.billTextBox.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTextBox.Location = new System.Drawing.Point(18, 45);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(170, 40);
            this.billTextBox.TabIndex = 0;
            this.billTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billTextBox.TextChanged += new System.EventHandler(this.billTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill:";
            // 
            // tipTrackBar
            // 
            this.tipTrackBar.Location = new System.Drawing.Point(18, 148);
            this.tipTrackBar.Name = "tipTrackBar";
            this.tipTrackBar.Size = new System.Drawing.Size(170, 45);
            this.tipTrackBar.TabIndex = 2;
            this.tipTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tipTrackBar.ValueChanged += new System.EventHandler(this.tipTrackBar_ValueChanged);
            // 
            // peopleUpDown
            // 
            this.peopleUpDown.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleUpDown.Location = new System.Drawing.Point(18, 232);
            this.peopleUpDown.Name = "peopleUpDown";
            this.peopleUpDown.Size = new System.Drawing.Size(170, 40);
            this.peopleUpDown.TabIndex = 3;
            this.peopleUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peopleUpDown.ValueChanged += new System.EventHandler(this.peopleUpDown_ValueChanged);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(321, 47);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(124, 45);
            this.tipLabel.TabIndex = 4;
            this.tipLabel.Text = "label2";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(321, 148);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(124, 45);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "label3";
            // 
            // tipTrackBarLabel
            // 
            this.tipTrackBarLabel.AutoSize = true;
            this.tipTrackBarLabel.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipTrackBarLabel.Location = new System.Drawing.Point(67, 112);
            this.tipTrackBarLabel.Name = "tipTrackBarLabel";
            this.tipTrackBarLabel.Size = new System.Drawing.Size(69, 33);
            this.tipTrackBarLabel.TabIndex = 6;
            this.tipTrackBarLabel.Text = "15%";
            // 
            // billErrorLabel
            // 
            this.billErrorLabel.AutoSize = true;
            this.billErrorLabel.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.billErrorLabel.Location = new System.Drawing.Point(15, 88);
            this.billErrorLabel.Name = "billErrorLabel";
            this.billErrorLabel.Size = new System.Drawing.Size(141, 13);
            this.billErrorLabel.TabIndex = 7;
            this.billErrorLabel.Text = "Please enter a valid number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "per person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billErrorLabel);
            this.Controls.Add(this.tipTrackBarLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.peopleUpDown);
            this.Controls.Add(this.tipTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tipTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tipTrackBar;
        private System.Windows.Forms.NumericUpDown peopleUpDown;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tipTrackBarLabel;
        private System.Windows.Forms.Label billErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

