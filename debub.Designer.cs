namespace battleTest
{
    partial class debub
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
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.HPScroll = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMP = new System.Windows.Forms.Label();
            this.MPScroll = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbAllStatus = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.attackScroll = new System.Windows.Forms.HScrollBar();
            this.accuracyScroll = new System.Windows.Forms.HScrollBar();
            this.spiritScroll = new System.Windows.Forms.HScrollBar();
            this.defenseScroll = new System.Windows.Forms.HScrollBar();
            this.evasionScroll = new System.Windows.Forms.HScrollBar();
            this.willScroll = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.labelSpirit = new System.Windows.Forms.Label();
            this.labelWill = new System.Windows.Forms.Label();
            this.labelEvasion = new System.Windows.Forms.Label();
            this.labelDefense = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.speedScroll = new System.Windows.Forms.HScrollBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCharacters
            // 
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.Location = new System.Drawing.Point(12, 25);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(120, 69);
            this.listCharacters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character List:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(9, 100);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // HPScroll
            // 
            this.HPScroll.Location = new System.Drawing.Point(144, 25);
            this.HPScroll.Maximum = 1000;
            this.HPScroll.Minimum = 1;
            this.HPScroll.Name = "HPScroll";
            this.HPScroll.Size = new System.Drawing.Size(96, 17);
            this.HPScroll.TabIndex = 3;
            this.HPScroll.Value = 1;
            this.HPScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HPScroll_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current HP:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(243, 29);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(31, 13);
            this.labelHP.TabIndex = 5;
            this.labelHP.Text = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(243, 59);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(31, 13);
            this.labelMP.TabIndex = 8;
            this.labelMP.Text = "0000";
            // 
            // MPScroll
            // 
            this.MPScroll.Location = new System.Drawing.Point(144, 55);
            this.MPScroll.Maximum = 1000;
            this.MPScroll.Minimum = 1;
            this.MPScroll.Name = "MPScroll";
            this.MPScroll.Size = new System.Drawing.Size(96, 17);
            this.MPScroll.TabIndex = 7;
            this.MPScroll.Value = 1;
            this.MPScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MPScroll_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current MP:";
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Location = new System.Drawing.Point(12, 210);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(83, 56);
            this.statusList.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Statuses:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbAllStatus
            // 
            this.cbAllStatus.FormattingEnabled = true;
            this.cbAllStatus.Location = new System.Drawing.Point(9, 272);
            this.cbAllStatus.Name = "cbAllStatus";
            this.cbAllStatus.Size = new System.Drawing.Size(90, 21);
            this.cbAllStatus.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // attackScroll
            // 
            this.attackScroll.LargeChange = 1;
            this.attackScroll.Location = new System.Drawing.Point(101, 117);
            this.attackScroll.Maximum = 10;
            this.attackScroll.Minimum = 1;
            this.attackScroll.Name = "attackScroll";
            this.attackScroll.Size = new System.Drawing.Size(96, 17);
            this.attackScroll.TabIndex = 15;
            this.attackScroll.Value = 1;
            this.attackScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.attackScroll_Scroll);
            // 
            // accuracyScroll
            // 
            this.accuracyScroll.LargeChange = 1;
            this.accuracyScroll.Location = new System.Drawing.Point(101, 154);
            this.accuracyScroll.Maximum = 10;
            this.accuracyScroll.Minimum = 1;
            this.accuracyScroll.Name = "accuracyScroll";
            this.accuracyScroll.Size = new System.Drawing.Size(96, 17);
            this.accuracyScroll.TabIndex = 16;
            this.accuracyScroll.Value = 1;
            this.accuracyScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.accuracyScroll_Scroll);
            // 
            // spiritScroll
            // 
            this.spiritScroll.LargeChange = 1;
            this.spiritScroll.Location = new System.Drawing.Point(101, 190);
            this.spiritScroll.Maximum = 10;
            this.spiritScroll.Minimum = 1;
            this.spiritScroll.Name = "spiritScroll";
            this.spiritScroll.Size = new System.Drawing.Size(96, 17);
            this.spiritScroll.TabIndex = 17;
            this.spiritScroll.Value = 1;
            this.spiritScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.spiritScroll_Scroll);
            // 
            // defenseScroll
            // 
            this.defenseScroll.LargeChange = 1;
            this.defenseScroll.Location = new System.Drawing.Point(229, 117);
            this.defenseScroll.Maximum = 10;
            this.defenseScroll.Minimum = 1;
            this.defenseScroll.Name = "defenseScroll";
            this.defenseScroll.Size = new System.Drawing.Size(96, 17);
            this.defenseScroll.TabIndex = 18;
            this.defenseScroll.Value = 1;
            this.defenseScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.defenseScroll_Scroll);
            // 
            // evasionScroll
            // 
            this.evasionScroll.LargeChange = 1;
            this.evasionScroll.Location = new System.Drawing.Point(229, 154);
            this.evasionScroll.Maximum = 10;
            this.evasionScroll.Minimum = 1;
            this.evasionScroll.Name = "evasionScroll";
            this.evasionScroll.Size = new System.Drawing.Size(96, 17);
            this.evasionScroll.TabIndex = 19;
            this.evasionScroll.Value = 1;
            this.evasionScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.evasionScroll_Scroll);
            // 
            // willScroll
            // 
            this.willScroll.LargeChange = 1;
            this.willScroll.Location = new System.Drawing.Point(229, 190);
            this.willScroll.Maximum = 10;
            this.willScroll.Minimum = 1;
            this.willScroll.Name = "willScroll";
            this.willScroll.Size = new System.Drawing.Size(96, 17);
            this.willScroll.TabIndex = 20;
            this.willScroll.Value = 1;
            this.willScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.willScroll_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Attack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Defense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Accuracy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Evasion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Spirit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Will";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(201, 121);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(19, 13);
            this.labelAttack.TabIndex = 27;
            this.labelAttack.Text = "00";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Location = new System.Drawing.Point(200, 158);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(19, 13);
            this.labelAccuracy.TabIndex = 28;
            this.labelAccuracy.Text = "00";
            // 
            // labelSpirit
            // 
            this.labelSpirit.AutoSize = true;
            this.labelSpirit.Location = new System.Drawing.Point(201, 190);
            this.labelSpirit.Name = "labelSpirit";
            this.labelSpirit.Size = new System.Drawing.Size(19, 13);
            this.labelSpirit.TabIndex = 29;
            this.labelSpirit.Text = "00";
            // 
            // labelWill
            // 
            this.labelWill.AutoSize = true;
            this.labelWill.Location = new System.Drawing.Point(328, 190);
            this.labelWill.Name = "labelWill";
            this.labelWill.Size = new System.Drawing.Size(19, 13);
            this.labelWill.TabIndex = 32;
            this.labelWill.Text = "00";
            // 
            // labelEvasion
            // 
            this.labelEvasion.AutoSize = true;
            this.labelEvasion.Location = new System.Drawing.Point(327, 158);
            this.labelEvasion.Name = "labelEvasion";
            this.labelEvasion.Size = new System.Drawing.Size(19, 13);
            this.labelEvasion.TabIndex = 31;
            this.labelEvasion.Text = "00";
            // 
            // labelDefense
            // 
            this.labelDefense.AutoSize = true;
            this.labelDefense.Location = new System.Drawing.Point(328, 121);
            this.labelDefense.Name = "labelDefense";
            this.labelDefense.Size = new System.Drawing.Size(19, 13);
            this.labelDefense.TabIndex = 30;
            this.labelDefense.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Speed";
            // 
            // speedScroll
            // 
            this.speedScroll.LargeChange = 1;
            this.speedScroll.Location = new System.Drawing.Point(144, 87);
            this.speedScroll.Maximum = 10;
            this.speedScroll.Minimum = 1;
            this.speedScroll.Name = "speedScroll";
            this.speedScroll.Size = new System.Drawing.Size(96, 17);
            this.speedScroll.TabIndex = 34;
            this.speedScroll.Value = 1;
            this.speedScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedScroll_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(243, 91);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(25, 13);
            this.labelSpeed.TabIndex = 35;
            this.labelSpeed.Text = "000";
            // 
            // debub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 299);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.speedScroll);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelWill);
            this.Controls.Add(this.labelEvasion);
            this.Controls.Add(this.labelDefense);
            this.Controls.Add(this.labelSpirit);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.willScroll);
            this.Controls.Add(this.evasionScroll);
            this.Controls.Add(this.defenseScroll);
            this.Controls.Add(this.spiritScroll);
            this.Controls.Add(this.accuracyScroll);
            this.Controls.Add(this.attackScroll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbAllStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.MPScroll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HPScroll);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCharacters);
            this.Name = "debub";
            this.Text = "debub";
            this.Load += new System.EventHandler(this.debub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCharacters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.HScrollBar HPScroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.HScrollBar MPScroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox statusList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbAllStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar attackScroll;
        private System.Windows.Forms.HScrollBar accuracyScroll;
        private System.Windows.Forms.HScrollBar spiritScroll;
        private System.Windows.Forms.HScrollBar defenseScroll;
        private System.Windows.Forms.HScrollBar evasionScroll;
        private System.Windows.Forms.HScrollBar willScroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.Label labelSpirit;
        private System.Windows.Forms.Label labelWill;
        private System.Windows.Forms.Label labelEvasion;
        private System.Windows.Forms.Label labelDefense;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.HScrollBar speedScroll;
        private System.Windows.Forms.Label labelSpeed;
    }
}