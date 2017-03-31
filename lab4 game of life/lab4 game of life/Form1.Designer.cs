namespace lab4_game_of_life
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_NewPattern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Circle = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Cycle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_NewPattern
            // 
            this.btn_NewPattern.Location = new System.Drawing.Point(146, 42);
            this.btn_NewPattern.Name = "btn_NewPattern";
            this.btn_NewPattern.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPattern.TabIndex = 0;
            this.btn_NewPattern.Text = "New Pattern";
            this.btn_NewPattern.UseVisualStyleBackColor = true;
            this.btn_NewPattern.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cycle";
            // 
            // lbl_Circle
            // 
            this.lbl_Circle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Circle.Location = new System.Drawing.Point(143, 127);
            this.lbl_Circle.Name = "lbl_Circle";
            this.lbl_Circle.Size = new System.Drawing.Size(100, 23);
            this.lbl_Circle.TabIndex = 2;
            this.lbl_Circle.Text = "label2";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(40, 193);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(146, 193);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Cycle
            // 
            this.btn_Cycle.Location = new System.Drawing.Point(254, 193);
            this.btn_Cycle.Name = "btn_Cycle";
            this.btn_Cycle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cycle.TabIndex = 5;
            this.btn_Cycle.Text = "Cycle";
            this.btn_Cycle.UseVisualStyleBackColor = true;
            this.btn_Cycle.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 274);
            this.Controls.Add(this.btn_Cycle);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Circle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Circle;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Cycle;
        private System.Windows.Forms.Timer timer1;
    }
}

