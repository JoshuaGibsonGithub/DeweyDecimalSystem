
namespace PROG7312_Part_1
{
    partial class IdentifyAreasForm
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
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.Location = new System.Drawing.Point(32, 117);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(115, 121);
            this.lbLeft.TabIndex = 0;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.Location = new System.Drawing.Point(173, 117);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(342, 121);
            this.lbRight.TabIndex = 1;
            this.lbRight.SelectedIndexChanged += new System.EventHandler(this.lbRight_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(32, 281);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Answers";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(32, 253);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 3;
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Enabled = true;
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "Identify Areas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Call Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descriptions";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(469, 415);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 17;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(244, 415);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // IdentifyAreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.MaximumSize = new System.Drawing.Size(572, 489);
            this.MinimumSize = new System.Drawing.Size(572, 489);
            this.Name = "IdentifyAreasForm";
            this.Text = "IdentifyAreasForm";
            this.Load += new System.EventHandler(this.IdentifyAreasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnHelp;
    }
}