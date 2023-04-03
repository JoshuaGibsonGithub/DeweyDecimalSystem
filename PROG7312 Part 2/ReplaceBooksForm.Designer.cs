
namespace PROG7312_Part_1
{
    partial class ReplaceBooksForm
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
            this.lbCallNumbers = new System.Windows.Forms.ListBox();
            this.lbSortedList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCallNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCallNumbers
            // 
            this.lbCallNumbers.FormattingEnabled = true;
            this.lbCallNumbers.Location = new System.Drawing.Point(18, 103);
            this.lbCallNumbers.Name = "lbCallNumbers";
            this.lbCallNumbers.Size = new System.Drawing.Size(120, 199);
            this.lbCallNumbers.TabIndex = 1;
            // 
            // lbSortedList
            // 
            this.lbSortedList.FormattingEnabled = true;
            this.lbSortedList.Location = new System.Drawing.Point(263, 103);
            this.lbSortedList.Name = "lbSortedList";
            this.lbSortedList.Size = new System.Drawing.Size(120, 199);
            this.lbSortedList.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Call Number";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCallNumber
            // 
            this.lblCallNumber.AutoSize = true;
            this.lblCallNumber.Location = new System.Drawing.Point(144, 103);
            this.lblCallNumber.Name = "lblCallNumber";
            this.lblCallNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCallNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Randomly Generated Call Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Sorted Call Numbers";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(137, 392);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 7;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(18, 416);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(165, 416);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(308, 416);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Enabled = true;
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(144, 352);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Replace Books";
            // 
            // ReplaceBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCallNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSortedList);
            this.Controls.Add(this.lbCallNumbers);
            this.MaximumSize = new System.Drawing.Size(419, 530);
            this.MinimumSize = new System.Drawing.Size(419, 530);
            this.Name = "ReplaceBooksForm";
            this.Text = "ReplaceBooksForm";
            this.Load += new System.EventHandler(this.ReplaceBooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCallNumbers;
        private System.Windows.Forms.ListBox lbSortedList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCallNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label3;
    }
}