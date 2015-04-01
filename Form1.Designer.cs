namespace battleTest
{
    partial class CharacterForm
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
            this.PBHealth = new System.Windows.Forms.ProgressBar();
            this.PBStamina = new System.Windows.Forms.ProgressBar();
            this.PBAttack = new System.Windows.Forms.ProgressBar();
            this.PBAccuracy = new System.Windows.Forms.ProgressBar();
            this.PBSpirit = new System.Windows.Forms.ProgressBar();
            this.PBDefense = new System.Windows.Forms.ProgressBar();
            this.PBEvasion = new System.Windows.Forms.ProgressBar();
            this.PBWill = new System.Windows.Forms.ProgressBar();
            this.PBSpeed = new System.Windows.Forms.ProgressBar();
            this.Health = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.healthNum = new System.Windows.Forms.Label();
            this.staminaNum = new System.Windows.Forms.Label();
            this.attackNum = new System.Windows.Forms.Label();
            this.accuracyNum = new System.Windows.Forms.Label();
            this.spiritNum = new System.Windows.Forms.Label();
            this.willNum = new System.Windows.Forms.Label();
            this.evasionNum = new System.Windows.Forms.Label();
            this.defenseNum = new System.Windows.Forms.Label();
            this.speedNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attack";
            // 
            // PBHealth
            // 
            this.PBHealth.BackColor = System.Drawing.Color.Black;
            this.PBHealth.ForeColor = System.Drawing.Color.Red;
            this.PBHealth.Location = new System.Drawing.Point(66, 5);
            this.PBHealth.Maximum = 1000;
            this.PBHealth.Name = "PBHealth";
            this.PBHealth.Size = new System.Drawing.Size(91, 20);
            this.PBHealth.Step = 5;
            this.PBHealth.TabIndex = 4;
            // 
            // PBStamina
            // 
            this.PBStamina.BackColor = System.Drawing.Color.Black;
            this.PBStamina.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PBStamina.Location = new System.Drawing.Point(66, 31);
            this.PBStamina.Maximum = 1000;
            this.PBStamina.Name = "PBStamina";
            this.PBStamina.Size = new System.Drawing.Size(91, 20);
            this.PBStamina.Step = 5;
            this.PBStamina.TabIndex = 5;
            // 
            // PBAttack
            // 
            this.PBAttack.BackColor = System.Drawing.Color.Black;
            this.PBAttack.ForeColor = System.Drawing.Color.Yellow;
            this.PBAttack.Location = new System.Drawing.Point(66, 57);
            this.PBAttack.Maximum = 1000;
            this.PBAttack.Name = "PBAttack";
            this.PBAttack.Size = new System.Drawing.Size(91, 20);
            this.PBAttack.Step = 5;
            this.PBAttack.TabIndex = 6;
            // 
            // PBAccuracy
            // 
            this.PBAccuracy.BackColor = System.Drawing.Color.Black;
            this.PBAccuracy.ForeColor = System.Drawing.Color.Yellow;
            this.PBAccuracy.Location = new System.Drawing.Point(66, 83);
            this.PBAccuracy.Maximum = 1000;
            this.PBAccuracy.Name = "PBAccuracy";
            this.PBAccuracy.Size = new System.Drawing.Size(91, 20);
            this.PBAccuracy.Step = 5;
            this.PBAccuracy.TabIndex = 7;
            // 
            // PBSpirit
            // 
            this.PBSpirit.BackColor = System.Drawing.Color.Black;
            this.PBSpirit.ForeColor = System.Drawing.Color.Yellow;
            this.PBSpirit.Location = new System.Drawing.Point(66, 109);
            this.PBSpirit.Maximum = 1000;
            this.PBSpirit.Name = "PBSpirit";
            this.PBSpirit.Size = new System.Drawing.Size(91, 20);
            this.PBSpirit.Step = 5;
            this.PBSpirit.TabIndex = 8;
            // 
            // PBDefense
            // 
            this.PBDefense.BackColor = System.Drawing.Color.Black;
            this.PBDefense.ForeColor = System.Drawing.Color.Yellow;
            this.PBDefense.Location = new System.Drawing.Point(249, 57);
            this.PBDefense.Maximum = 1000;
            this.PBDefense.Name = "PBDefense";
            this.PBDefense.Size = new System.Drawing.Size(91, 20);
            this.PBDefense.Step = 5;
            this.PBDefense.TabIndex = 9;
            // 
            // PBEvasion
            // 
            this.PBEvasion.BackColor = System.Drawing.Color.Black;
            this.PBEvasion.ForeColor = System.Drawing.Color.Yellow;
            this.PBEvasion.Location = new System.Drawing.Point(249, 83);
            this.PBEvasion.Maximum = 1000;
            this.PBEvasion.Name = "PBEvasion";
            this.PBEvasion.Size = new System.Drawing.Size(91, 20);
            this.PBEvasion.Step = 5;
            this.PBEvasion.TabIndex = 10;
            // 
            // PBWill
            // 
            this.PBWill.BackColor = System.Drawing.Color.Black;
            this.PBWill.ForeColor = System.Drawing.Color.Yellow;
            this.PBWill.Location = new System.Drawing.Point(249, 109);
            this.PBWill.Maximum = 1000;
            this.PBWill.Name = "PBWill";
            this.PBWill.Size = new System.Drawing.Size(91, 20);
            this.PBWill.Step = 5;
            this.PBWill.TabIndex = 11;
            // 
            // PBSpeed
            // 
            this.PBSpeed.BackColor = System.Drawing.Color.Black;
            this.PBSpeed.ForeColor = System.Drawing.Color.Yellow;
            this.PBSpeed.Location = new System.Drawing.Point(249, 5);
            this.PBSpeed.Maximum = 1000;
            this.PBSpeed.Name = "PBSpeed";
            this.PBSpeed.Size = new System.Drawing.Size(91, 20);
            this.PBSpeed.Step = 5;
            this.PBSpeed.TabIndex = 12;
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(4, 12);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(38, 13);
            this.Health.TabIndex = 13;
            this.Health.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stamina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Accuracy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Spirit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Defense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Evasion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Will";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Speed";
            // 
            // healthNum
            // 
            this.healthNum.AutoSize = true;
            this.healthNum.BackColor = System.Drawing.Color.Black;
            this.healthNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.healthNum.Location = new System.Drawing.Point(161, 10);
            this.healthNum.Name = "healthNum";
            this.healthNum.Size = new System.Drawing.Size(29, 15);
            this.healthNum.TabIndex = 21;
            this.healthNum.Text = "1000";
            // 
            // staminaNum
            // 
            this.staminaNum.AutoSize = true;
            this.staminaNum.BackColor = System.Drawing.Color.Black;
            this.staminaNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staminaNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staminaNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.staminaNum.Location = new System.Drawing.Point(161, 36);
            this.staminaNum.Name = "staminaNum";
            this.staminaNum.Size = new System.Drawing.Size(29, 15);
            this.staminaNum.TabIndex = 21;
            this.staminaNum.Text = "1000";
            // 
            // attackNum
            // 
            this.attackNum.AutoSize = true;
            this.attackNum.BackColor = System.Drawing.Color.Black;
            this.attackNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.attackNum.Location = new System.Drawing.Point(161, 62);
            this.attackNum.Name = "attackNum";
            this.attackNum.Size = new System.Drawing.Size(29, 15);
            this.attackNum.TabIndex = 21;
            this.attackNum.Text = "1000";
            // 
            // accuracyNum
            // 
            this.accuracyNum.AutoSize = true;
            this.accuracyNum.BackColor = System.Drawing.Color.Black;
            this.accuracyNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accuracyNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accuracyNum.Location = new System.Drawing.Point(161, 88);
            this.accuracyNum.Name = "accuracyNum";
            this.accuracyNum.Size = new System.Drawing.Size(29, 15);
            this.accuracyNum.TabIndex = 21;
            this.accuracyNum.Text = "1000";
            // 
            // spiritNum
            // 
            this.spiritNum.AutoSize = true;
            this.spiritNum.BackColor = System.Drawing.Color.Black;
            this.spiritNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spiritNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spiritNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.spiritNum.Location = new System.Drawing.Point(161, 114);
            this.spiritNum.Name = "spiritNum";
            this.spiritNum.Size = new System.Drawing.Size(29, 15);
            this.spiritNum.TabIndex = 21;
            this.spiritNum.Text = "1000";
            // 
            // willNum
            // 
            this.willNum.AutoSize = true;
            this.willNum.BackColor = System.Drawing.Color.Black;
            this.willNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.willNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.willNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.willNum.Location = new System.Drawing.Point(344, 114);
            this.willNum.Name = "willNum";
            this.willNum.Size = new System.Drawing.Size(29, 15);
            this.willNum.TabIndex = 21;
            this.willNum.Text = "1000";
            // 
            // evasionNum
            // 
            this.evasionNum.AutoSize = true;
            this.evasionNum.BackColor = System.Drawing.Color.Black;
            this.evasionNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evasionNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evasionNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.evasionNum.Location = new System.Drawing.Point(344, 88);
            this.evasionNum.Name = "evasionNum";
            this.evasionNum.Size = new System.Drawing.Size(29, 15);
            this.evasionNum.TabIndex = 21;
            this.evasionNum.Text = "1000";
            // 
            // defenseNum
            // 
            this.defenseNum.AutoSize = true;
            this.defenseNum.BackColor = System.Drawing.Color.Black;
            this.defenseNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defenseNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.defenseNum.Location = new System.Drawing.Point(344, 62);
            this.defenseNum.Name = "defenseNum";
            this.defenseNum.Size = new System.Drawing.Size(29, 15);
            this.defenseNum.TabIndex = 21;
            this.defenseNum.Text = "1000";
            // 
            // speedNum
            // 
            this.speedNum.AutoSize = true;
            this.speedNum.BackColor = System.Drawing.Color.Black;
            this.speedNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedNum.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.speedNum.Location = new System.Drawing.Point(344, 10);
            this.speedNum.Name = "speedNum";
            this.speedNum.Size = new System.Drawing.Size(29, 15);
            this.speedNum.TabIndex = 21;
            this.speedNum.Text = "1000";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(378, 133);
            this.Controls.Add(this.speedNum);
            this.Controls.Add(this.defenseNum);
            this.Controls.Add(this.evasionNum);
            this.Controls.Add(this.willNum);
            this.Controls.Add(this.spiritNum);
            this.Controls.Add(this.accuracyNum);
            this.Controls.Add(this.attackNum);
            this.Controls.Add(this.staminaNum);
            this.Controls.Add(this.healthNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.PBSpeed);
            this.Controls.Add(this.PBWill);
            this.Controls.Add(this.PBEvasion);
            this.Controls.Add(this.PBDefense);
            this.Controls.Add(this.PBSpirit);
            this.Controls.Add(this.PBAccuracy);
            this.Controls.Add(this.PBAttack);
            this.Controls.Add(this.PBStamina);
            this.Controls.Add(this.PBHealth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Character:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PBHealth;
        private System.Windows.Forms.ProgressBar PBStamina;
        private System.Windows.Forms.ProgressBar PBAttack;
        private System.Windows.Forms.ProgressBar PBAccuracy;
        private System.Windows.Forms.ProgressBar PBSpirit;
        private System.Windows.Forms.ProgressBar PBDefense;
        private System.Windows.Forms.ProgressBar PBEvasion;
        private System.Windows.Forms.ProgressBar PBWill;
        private System.Windows.Forms.ProgressBar PBSpeed;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label healthNum;
        private System.Windows.Forms.Label staminaNum;
        private System.Windows.Forms.Label attackNum;
        private System.Windows.Forms.Label accuracyNum;
        private System.Windows.Forms.Label spiritNum;
        private System.Windows.Forms.Label willNum;
        private System.Windows.Forms.Label evasionNum;
        private System.Windows.Forms.Label defenseNum;
        private System.Windows.Forms.Label speedNum;
    }
}

