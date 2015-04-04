namespace battleTest
{
    partial class battle
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.skillButton1 = new System.Windows.Forms.Button();
            this.skillButton2 = new System.Windows.Forms.Button();
            this.labelPlayer1Health = new System.Windows.Forms.Label();
            this.labelPlayer1Energy = new System.Windows.Forms.Label();
            this.labelPlayer1Status = new System.Windows.Forms.Label();
            this.labelNPC1Status = new System.Windows.Forms.Label();
            this.labelNPC1Energy = new System.Windows.Forms.Label();
            this.labelNPC1Health = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Button();
            this.NPC1 = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Player3 = new System.Windows.Forms.Button();
            this.NPC2 = new System.Windows.Forms.Button();
            this.NPC3 = new System.Windows.Forms.Button();
            this.labelPlayer2Health = new System.Windows.Forms.Label();
            this.labelPlayer2Energy = new System.Windows.Forms.Label();
            this.labelPlayer2Status = new System.Windows.Forms.Label();
            this.labelNPC2Status = new System.Windows.Forms.Label();
            this.labelNPC2Energy = new System.Windows.Forms.Label();
            this.labelNPC2Health = new System.Windows.Forms.Label();
            this.labelNPC3Status = new System.Windows.Forms.Label();
            this.labelNPC3Energy = new System.Windows.Forms.Label();
            this.labelNPC3Health = new System.Windows.Forms.Label();
            this.labelPlayer3Status = new System.Windows.Forms.Label();
            this.labelPlayer3Energy = new System.Windows.Forms.Label();
            this.labelPlayer3Health = new System.Windows.Forms.Label();
            this.skillButton3 = new System.Windows.Forms.Button();
            this.skillButton4 = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 132);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // skillButton1
            // 
            this.skillButton1.Location = new System.Drawing.Point(370, 71);
            this.skillButton1.Name = "skillButton1";
            this.skillButton1.Size = new System.Drawing.Size(75, 23);
            this.skillButton1.TabIndex = 5;
            this.skillButton1.Text = "Skill one";
            this.skillButton1.UseVisualStyleBackColor = true;
            this.skillButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skillButton2
            // 
            this.skillButton2.Location = new System.Drawing.Point(370, 100);
            this.skillButton2.Name = "skillButton2";
            this.skillButton2.Size = new System.Drawing.Size(75, 23);
            this.skillButton2.TabIndex = 8;
            this.skillButton2.Text = "Skill two";
            this.skillButton2.UseVisualStyleBackColor = true;
            this.skillButton2.Click += new System.EventHandler(this.skillButton2_Click);
            // 
            // labelPlayer1Health
            // 
            this.labelPlayer1Health.AutoSize = true;
            this.labelPlayer1Health.Location = new System.Drawing.Point(12, 31);
            this.labelPlayer1Health.Name = "labelPlayer1Health";
            this.labelPlayer1Health.Size = new System.Drawing.Size(41, 13);
            this.labelPlayer1Health.TabIndex = 19;
            this.labelPlayer1Health.Text = "Health:";
            // 
            // labelPlayer1Energy
            // 
            this.labelPlayer1Energy.AutoSize = true;
            this.labelPlayer1Energy.Location = new System.Drawing.Point(12, 44);
            this.labelPlayer1Energy.Name = "labelPlayer1Energy";
            this.labelPlayer1Energy.Size = new System.Drawing.Size(43, 13);
            this.labelPlayer1Energy.TabIndex = 20;
            this.labelPlayer1Energy.Text = "Energy:";
            // 
            // labelPlayer1Status
            // 
            this.labelPlayer1Status.AutoSize = true;
            this.labelPlayer1Status.Location = new System.Drawing.Point(12, 57);
            this.labelPlayer1Status.Name = "labelPlayer1Status";
            this.labelPlayer1Status.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer1Status.TabIndex = 28;
            this.labelPlayer1Status.Text = "status";
            // 
            // labelNPC1Status
            // 
            this.labelNPC1Status.AutoSize = true;
            this.labelNPC1Status.Location = new System.Drawing.Point(12, 263);
            this.labelNPC1Status.Name = "labelNPC1Status";
            this.labelNPC1Status.Size = new System.Drawing.Size(35, 13);
            this.labelNPC1Status.TabIndex = 39;
            this.labelNPC1Status.Text = "status";
            // 
            // labelNPC1Energy
            // 
            this.labelNPC1Energy.AutoSize = true;
            this.labelNPC1Energy.Location = new System.Drawing.Point(12, 250);
            this.labelNPC1Energy.Name = "labelNPC1Energy";
            this.labelNPC1Energy.Size = new System.Drawing.Size(43, 13);
            this.labelNPC1Energy.TabIndex = 31;
            this.labelNPC1Energy.Text = "Energy:";
            // 
            // labelNPC1Health
            // 
            this.labelNPC1Health.AutoSize = true;
            this.labelNPC1Health.Location = new System.Drawing.Point(12, 237);
            this.labelNPC1Health.Name = "labelNPC1Health";
            this.labelNPC1Health.Size = new System.Drawing.Size(41, 13);
            this.labelNPC1Health.TabIndex = 30;
            this.labelNPC1Health.Text = "Health:";
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(11, 5);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(105, 23);
            this.Player1.TabIndex = 40;
            this.Player1.Text = "Character";
            this.Player1.UseVisualStyleBackColor = true;
            this.Player1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NPC1
            // 
            this.NPC1.Location = new System.Drawing.Point(11, 211);
            this.NPC1.Name = "NPC1";
            this.NPC1.Size = new System.Drawing.Size(105, 23);
            this.NPC1.TabIndex = 41;
            this.NPC1.Text = "Character";
            this.NPC1.UseVisualStyleBackColor = true;
            this.NPC1.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(370, 263);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 42;
            this.MenuButton.Text = "Start";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(143, 5);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(105, 23);
            this.Player2.TabIndex = 43;
            this.Player2.Text = "Character";
            this.Player2.UseVisualStyleBackColor = true;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player3
            // 
            this.Player3.Location = new System.Drawing.Point(276, 5);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(105, 23);
            this.Player3.TabIndex = 44;
            this.Player3.Text = "Character";
            this.Player3.UseVisualStyleBackColor = true;
            this.Player3.Click += new System.EventHandler(this.Player3_Click);
            // 
            // NPC2
            // 
            this.NPC2.Location = new System.Drawing.Point(143, 211);
            this.NPC2.Name = "NPC2";
            this.NPC2.Size = new System.Drawing.Size(105, 23);
            this.NPC2.TabIndex = 45;
            this.NPC2.Text = "Character";
            this.NPC2.UseVisualStyleBackColor = true;
            this.NPC2.Click += new System.EventHandler(this.NPC2_Click);
            // 
            // NPC3
            // 
            this.NPC3.Location = new System.Drawing.Point(276, 211);
            this.NPC3.Name = "NPC3";
            this.NPC3.Size = new System.Drawing.Size(105, 23);
            this.NPC3.TabIndex = 46;
            this.NPC3.Text = "Character";
            this.NPC3.UseVisualStyleBackColor = true;
            this.NPC3.Click += new System.EventHandler(this.NPC3_Click);
            // 
            // labelPlayer2Health
            // 
            this.labelPlayer2Health.AutoSize = true;
            this.labelPlayer2Health.Location = new System.Drawing.Point(140, 32);
            this.labelPlayer2Health.Name = "labelPlayer2Health";
            this.labelPlayer2Health.Size = new System.Drawing.Size(41, 13);
            this.labelPlayer2Health.TabIndex = 47;
            this.labelPlayer2Health.Text = "Heatlh:";
            // 
            // labelPlayer2Energy
            // 
            this.labelPlayer2Energy.AutoSize = true;
            this.labelPlayer2Energy.Location = new System.Drawing.Point(140, 45);
            this.labelPlayer2Energy.Name = "labelPlayer2Energy";
            this.labelPlayer2Energy.Size = new System.Drawing.Size(43, 13);
            this.labelPlayer2Energy.TabIndex = 49;
            this.labelPlayer2Energy.Text = "Energy:";
            // 
            // labelPlayer2Status
            // 
            this.labelPlayer2Status.AutoSize = true;
            this.labelPlayer2Status.Location = new System.Drawing.Point(140, 58);
            this.labelPlayer2Status.Name = "labelPlayer2Status";
            this.labelPlayer2Status.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer2Status.TabIndex = 50;
            this.labelPlayer2Status.Text = "status";
            // 
            // labelNPC2Status
            // 
            this.labelNPC2Status.AutoSize = true;
            this.labelNPC2Status.Location = new System.Drawing.Point(140, 263);
            this.labelNPC2Status.Name = "labelNPC2Status";
            this.labelNPC2Status.Size = new System.Drawing.Size(35, 13);
            this.labelNPC2Status.TabIndex = 53;
            this.labelNPC2Status.Text = "status";
            // 
            // labelNPC2Energy
            // 
            this.labelNPC2Energy.AutoSize = true;
            this.labelNPC2Energy.Location = new System.Drawing.Point(140, 250);
            this.labelNPC2Energy.Name = "labelNPC2Energy";
            this.labelNPC2Energy.Size = new System.Drawing.Size(43, 13);
            this.labelNPC2Energy.TabIndex = 52;
            this.labelNPC2Energy.Text = "Energy:";
            // 
            // labelNPC2Health
            // 
            this.labelNPC2Health.AutoSize = true;
            this.labelNPC2Health.Location = new System.Drawing.Point(140, 237);
            this.labelNPC2Health.Name = "labelNPC2Health";
            this.labelNPC2Health.Size = new System.Drawing.Size(41, 13);
            this.labelNPC2Health.TabIndex = 51;
            this.labelNPC2Health.Text = "Heatlh:";
            // 
            // labelNPC3Status
            // 
            this.labelNPC3Status.AutoSize = true;
            this.labelNPC3Status.Location = new System.Drawing.Point(273, 263);
            this.labelNPC3Status.Name = "labelNPC3Status";
            this.labelNPC3Status.Size = new System.Drawing.Size(35, 13);
            this.labelNPC3Status.TabIndex = 56;
            this.labelNPC3Status.Text = "status";
            // 
            // labelNPC3Energy
            // 
            this.labelNPC3Energy.AutoSize = true;
            this.labelNPC3Energy.Location = new System.Drawing.Point(273, 250);
            this.labelNPC3Energy.Name = "labelNPC3Energy";
            this.labelNPC3Energy.Size = new System.Drawing.Size(43, 13);
            this.labelNPC3Energy.TabIndex = 55;
            this.labelNPC3Energy.Text = "Energy:";
            // 
            // labelNPC3Health
            // 
            this.labelNPC3Health.AutoSize = true;
            this.labelNPC3Health.Location = new System.Drawing.Point(273, 237);
            this.labelNPC3Health.Name = "labelNPC3Health";
            this.labelNPC3Health.Size = new System.Drawing.Size(41, 13);
            this.labelNPC3Health.TabIndex = 54;
            this.labelNPC3Health.Text = "Heatlh:";
            // 
            // labelPlayer3Status
            // 
            this.labelPlayer3Status.AutoSize = true;
            this.labelPlayer3Status.Location = new System.Drawing.Point(275, 57);
            this.labelPlayer3Status.Name = "labelPlayer3Status";
            this.labelPlayer3Status.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer3Status.TabIndex = 59;
            this.labelPlayer3Status.Text = "status";
            // 
            // labelPlayer3Energy
            // 
            this.labelPlayer3Energy.AutoSize = true;
            this.labelPlayer3Energy.Location = new System.Drawing.Point(275, 44);
            this.labelPlayer3Energy.Name = "labelPlayer3Energy";
            this.labelPlayer3Energy.Size = new System.Drawing.Size(43, 13);
            this.labelPlayer3Energy.TabIndex = 58;
            this.labelPlayer3Energy.Text = "Energy:";
            // 
            // labelPlayer3Health
            // 
            this.labelPlayer3Health.AutoSize = true;
            this.labelPlayer3Health.Location = new System.Drawing.Point(275, 31);
            this.labelPlayer3Health.Name = "labelPlayer3Health";
            this.labelPlayer3Health.Size = new System.Drawing.Size(41, 13);
            this.labelPlayer3Health.TabIndex = 57;
            this.labelPlayer3Health.Text = "Heatlh:";
            // 
            // skillButton3
            // 
            this.skillButton3.Location = new System.Drawing.Point(370, 129);
            this.skillButton3.Name = "skillButton3";
            this.skillButton3.Size = new System.Drawing.Size(75, 23);
            this.skillButton3.TabIndex = 60;
            this.skillButton3.UseVisualStyleBackColor = true;
            // 
            // skillButton4
            // 
            this.skillButton4.Location = new System.Drawing.Point(370, 158);
            this.skillButton4.Name = "skillButton4";
            this.skillButton4.Size = new System.Drawing.Size(75, 23);
            this.skillButton4.TabIndex = 61;
            this.skillButton4.UseVisualStyleBackColor = true;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(370, 187);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(75, 23);
            this.InventoryButton.TabIndex = 62;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            // 
            // battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 289);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.skillButton4);
            this.Controls.Add(this.skillButton3);
            this.Controls.Add(this.labelPlayer3Status);
            this.Controls.Add(this.labelPlayer3Energy);
            this.Controls.Add(this.labelPlayer3Health);
            this.Controls.Add(this.labelNPC3Status);
            this.Controls.Add(this.labelNPC3Energy);
            this.Controls.Add(this.labelNPC3Health);
            this.Controls.Add(this.labelNPC2Status);
            this.Controls.Add(this.labelNPC2Energy);
            this.Controls.Add(this.labelNPC2Health);
            this.Controls.Add(this.labelPlayer2Status);
            this.Controls.Add(this.labelPlayer2Energy);
            this.Controls.Add(this.labelPlayer2Health);
            this.Controls.Add(this.NPC3);
            this.Controls.Add(this.NPC2);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.NPC1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.labelNPC1Status);
            this.Controls.Add(this.labelNPC1Energy);
            this.Controls.Add(this.labelNPC1Health);
            this.Controls.Add(this.labelPlayer1Status);
            this.Controls.Add(this.labelPlayer1Energy);
            this.Controls.Add(this.labelPlayer1Health);
            this.Controls.Add(this.skillButton2);
            this.Controls.Add(this.skillButton1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "battle";
            this.Text = "battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skillButton1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button skillButton2;
        private System.Windows.Forms.Label labelPlayer1Health;
        private System.Windows.Forms.Label labelPlayer1Energy;
        private System.Windows.Forms.Label labelPlayer1Status;
        private System.Windows.Forms.Label labelNPC1Status;
        private System.Windows.Forms.Label labelNPC1Energy;
        private System.Windows.Forms.Label labelNPC1Health;
        private System.Windows.Forms.Button Player1;
        private System.Windows.Forms.Button NPC1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button Player2;
        private System.Windows.Forms.Button Player3;
        private System.Windows.Forms.Button NPC2;
        private System.Windows.Forms.Button NPC3;
        private System.Windows.Forms.Label labelPlayer2Health;
        private System.Windows.Forms.Label labelPlayer2Energy;
        private System.Windows.Forms.Label labelPlayer2Status;
        private System.Windows.Forms.Label labelNPC2Status;
        private System.Windows.Forms.Label labelNPC2Energy;
        private System.Windows.Forms.Label labelNPC2Health;
        private System.Windows.Forms.Label labelNPC3Status;
        private System.Windows.Forms.Label labelNPC3Energy;
        private System.Windows.Forms.Label labelNPC3Health;
        private System.Windows.Forms.Label labelPlayer3Status;
        private System.Windows.Forms.Label labelPlayer3Energy;
        private System.Windows.Forms.Label labelPlayer3Health;
        private System.Windows.Forms.Button skillButton3;
        private System.Windows.Forms.Button skillButton4;
        private System.Windows.Forms.Button InventoryButton;
    }
}