namespace UFA
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
            this.A = new System.Windows.Forms.Label();
            this.Giz = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.YouWontBeNeedingThatAnyway = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Giz)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(12, 9);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(176, 13);
            this.A.TabIndex = 0;
            this.A.Text = "Ход передаетеся тебе - скорость";
            this.A.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Giz
            // 
            this.Giz.AllowUserToAddRows = false;
            this.Giz.AllowUserToDeleteRows = false;
            this.Giz.AllowUserToResizeColumns = false;
            this.Giz.AllowUserToResizeRows = false;
            this.Giz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Giz.ColumnHeadersVisible = false;
            this.Giz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3});
            this.Giz.Location = new System.Drawing.Point(12, 25);
            this.Giz.Name = "Giz";
            this.Giz.RowHeadersVisible = false;
            this.Giz.Size = new System.Drawing.Size(153, 153);
            this.Giz.TabIndex = 2;
            this.Giz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Giz_CellClick);
            // 
            // C1
            // 
            this.C1.HeaderText = "X1";
            this.C1.MinimumWidth = 10;
            this.C1.Name = "C1";
            this.C1.Width = 50;
            // 
            // C2
            // 
            this.C2.HeaderText = "X2";
            this.C2.Name = "C2";
            this.C2.Width = 50;
            // 
            // C3
            // 
            this.C3.HeaderText = "X3";
            this.C3.Name = "C3";
            this.C3.Width = 50;
            // 
            // YouWontBeNeedingThatAnyway
            // 
            this.YouWontBeNeedingThatAnyway.AutoSize = true;
            this.YouWontBeNeedingThatAnyway.Location = new System.Drawing.Point(171, 25);
            this.YouWontBeNeedingThatAnyway.Name = "YouWontBeNeedingThatAnyway";
            this.YouWontBeNeedingThatAnyway.Size = new System.Drawing.Size(33, 13);
            this.YouWontBeNeedingThatAnyway.TabIndex = 3;
            this.YouWontBeNeedingThatAnyway.Text = "Cчет:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(210, 25);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(22, 13);
            this.Score.TabIndex = 4;
            this.Score.Text = "0:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 198);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.YouWontBeNeedingThatAnyway);
            this.Controls.Add(this.Giz);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Крестики-Нолики на двоих";
            ((System.ComponentModel.ISupportInitialize)(this.Giz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A;
        private System.Windows.Forms.DataGridView Giz;
        private System.Windows.Forms.Label YouWontBeNeedingThatAnyway;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.DataGridViewButtonColumn C1;
        private System.Windows.Forms.DataGridViewButtonColumn C2;
        private System.Windows.Forms.DataGridViewButtonColumn C3;
    }
}

