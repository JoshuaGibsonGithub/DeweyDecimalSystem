
namespace PROG7312_Part_1
{
    partial class FindCallNumbersForm
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
            this.tView1 = new System.Windows.Forms.TreeView();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tView1
            // 
            this.tView1.Enabled = false;
            this.tView1.Location = new System.Drawing.Point(12, 12);
            this.tView1.Name = "tView1";
            this.tView1.Size = new System.Drawing.Size(10, 10);
            this.tView1.TabIndex = 0;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 102);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(51, 13);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "lblDisplay";
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(12, 130);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(349, 186);
            this.lbNumbers.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 331);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(241, 331);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 374);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(241, 374);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(120, 23);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Find Call Numbers";
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Enabled = true;
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Location = new System.Drawing.Point(168, 407);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.lblScoreLabel.TabIndex = 15;
            // 
            // FindCallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 429);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.tView1);
            this.MaximumSize = new System.Drawing.Size(402, 468);
            this.MinimumSize = new System.Drawing.Size(402, 468);
            this.Name = "FindCallNumbersForm";
            this.Text = "FindCallNumbersForm";
            this.Load += new System.EventHandler(this.FindCallNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tView1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label lblScoreLabel;
    }
}