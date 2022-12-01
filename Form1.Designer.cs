namespace Miner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startGameLab = new System.Windows.Forms.Label();
            this.settingsLLab = new System.Windows.Forms.Label();
            this.ExiteLab = new System.Windows.Forms.Label();
            this.comboDificaltyGame = new System.Windows.Forms.ComboBox();
            this.comboSizeField = new System.Windows.Forms.ComboBox();
            this.sizeField = new System.Windows.Forms.Label();
            this.dificaltyGame = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGameLab
            // 
            this.startGameLab.AutoSize = true;
            this.startGameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameLab.Location = new System.Drawing.Point(78, 157);
            this.startGameLab.Name = "startGameLab";
            this.startGameLab.Size = new System.Drawing.Size(104, 31);
            this.startGameLab.TabIndex = 0;
            this.startGameLab.Text = "Начать";
            this.startGameLab.Click += new System.EventHandler(this.StartGame);
            // 
            // settingsLLab
            // 
            this.settingsLLab.AutoSize = true;
            this.settingsLLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLLab.Location = new System.Drawing.Point(78, 228);
            this.settingsLLab.Name = "settingsLLab";
            this.settingsLLab.Size = new System.Drawing.Size(149, 31);
            this.settingsLLab.TabIndex = 1;
            this.settingsLLab.Text = "Настройки";
            this.settingsLLab.Click += new System.EventHandler(this.SettingsGame);
            // 
            // ExiteLab
            // 
            this.ExiteLab.AutoSize = true;
            this.ExiteLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExiteLab.Location = new System.Drawing.Point(78, 301);
            this.ExiteLab.Name = "ExiteLab";
            this.ExiteLab.Size = new System.Drawing.Size(93, 31);
            this.ExiteLab.TabIndex = 2;
            this.ExiteLab.Text = "Выйти";
            this.ExiteLab.Click += new System.EventHandler(this.ExiteGame);
            // 
            // comboDificaltyGame
            // 
            this.comboDificaltyGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDificaltyGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboDificaltyGame.FormattingEnabled = true;
            this.comboDificaltyGame.Items.AddRange(new object[] {
            "Легко ",
            "Нормально",
            "Сложно ",
            "Viber сложность"});
            this.comboDificaltyGame.Location = new System.Drawing.Point(275, 135);
            this.comboDificaltyGame.Name = "comboDificaltyGame";
            this.comboDificaltyGame.Size = new System.Drawing.Size(288, 39);
            this.comboDificaltyGame.TabIndex = 3;
            this.comboDificaltyGame.Visible = false;
            // 
            // comboSizeField
            // 
            this.comboSizeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSizeField.FormattingEnabled = true;
            this.comboSizeField.Items.AddRange(new object[] {
            "4",
            "8",
            "12"});
            this.comboSizeField.Location = new System.Drawing.Point(275, 47);
            this.comboSizeField.Name = "comboSizeField";
            this.comboSizeField.Size = new System.Drawing.Size(193, 39);
            this.comboSizeField.TabIndex = 6;
            this.comboSizeField.Visible = false;
            // 
            // sizeField
            // 
            this.sizeField.AutoSize = true;
            this.sizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeField.Location = new System.Drawing.Point(50, 50);
            this.sizeField.Name = "sizeField";
            this.sizeField.Size = new System.Drawing.Size(177, 31);
            this.sizeField.TabIndex = 7;
            this.sizeField.Text = "Размер поля";
            this.sizeField.Visible = false;
            // 
            // dificaltyGame
            // 
            this.dificaltyGame.AutoSize = true;
            this.dificaltyGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dificaltyGame.Location = new System.Drawing.Point(50, 143);
            this.dificaltyGame.Name = "dificaltyGame";
            this.dificaltyGame.Size = new System.Drawing.Size(219, 31);
            this.dificaltyGame.TabIndex = 8;
            this.dificaltyGame.Text = "Сложность игры";
            this.dificaltyGame.Visible = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(666, 508);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 31);
            this.back.TabIndex = 9;
            this.back.Text = "Принять";
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dificaltyGame);
            this.Controls.Add(this.sizeField);
            this.Controls.Add(this.comboSizeField);
            this.Controls.Add(this.comboDificaltyGame);
            this.Controls.Add(this.ExiteLab);
            this.Controls.Add(this.settingsLLab);
            this.Controls.Add(this.startGameLab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startGameLab;
        private System.Windows.Forms.Label settingsLLab;
        private System.Windows.Forms.Label ExiteLab;
        private System.Windows.Forms.ComboBox comboDificaltyGame;
        private System.Windows.Forms.ComboBox comboSizeField;
        private System.Windows.Forms.Label sizeField;
        private System.Windows.Forms.Label dificaltyGame;
        private System.Windows.Forms.Label back;
    }
}

