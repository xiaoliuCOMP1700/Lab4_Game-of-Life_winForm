namespace lab4_game_of_life
{
    partial class NewPattern_ModeDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbt_Red = new System.Windows.Forms.RadioButton();
            this.rbt_Green = new System.Windows.Forms.RadioButton();
            this.rbt_Grey = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_Grey);
            this.groupBox1.Controls.Add(this.rbt_Green);
            this.groupBox1.Controls.Add(this.rbt_Red);
            this.groupBox1.Location = new System.Drawing.Point(60, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 184);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(272, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(60, 290);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(252, 290);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2000";
            // 
            // rbt_Red
            // 
            this.rbt_Red.AutoSize = true;
            this.rbt_Red.Location = new System.Drawing.Point(17, 20);
            this.rbt_Red.Name = "rbt_Red";
            this.rbt_Red.Size = new System.Drawing.Size(45, 17);
            this.rbt_Red.TabIndex = 0;
            this.rbt_Red.TabStop = true;
            this.rbt_Red.Text = "Red";
            this.rbt_Red.UseVisualStyleBackColor = true;
            this.rbt_Red.CheckedChanged += new System.EventHandler(this.rbt_Red_CheckedChanged);
            // 
            // rbt_Green
            // 
            this.rbt_Green.AutoSize = true;
            this.rbt_Green.Location = new System.Drawing.Point(17, 44);
            this.rbt_Green.Name = "rbt_Green";
            this.rbt_Green.Size = new System.Drawing.Size(54, 17);
            this.rbt_Green.TabIndex = 1;
            this.rbt_Green.TabStop = true;
            this.rbt_Green.Text = "Green";
            this.rbt_Green.UseVisualStyleBackColor = true;
            this.rbt_Green.CheckedChanged += new System.EventHandler(this.rbt_Green_CheckedChanged);
            // 
            // rbt_Grey
            // 
            this.rbt_Grey.AutoSize = true;
            this.rbt_Grey.Location = new System.Drawing.Point(17, 68);
            this.rbt_Grey.Name = "rbt_Grey";
            this.rbt_Grey.Size = new System.Drawing.Size(47, 17);
            this.rbt_Grey.TabIndex = 2;
            this.rbt_Grey.TabStop = true;
            this.rbt_Grey.Text = "Grey";
            this.rbt_Grey.UseVisualStyleBackColor = true;
            this.rbt_Grey.CheckedChanged += new System.EventHandler(this.rbt_Grey_CheckedChanged);
            // 
            // NewPattern_ModeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPattern_ModeDialog";
            this.Text = "NewPattern_ModeDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_Grey;
        private System.Windows.Forms.RadioButton rbt_Green;
        private System.Windows.Forms.RadioButton rbt_Red;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}