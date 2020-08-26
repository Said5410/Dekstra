namespace MainAll
{
    partial class AllIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.DekstrBut = new System.Windows.Forms.Button();
            this.FordBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Визуализация алгоритмов на графах";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DekstrBut
            // 
            this.DekstrBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DekstrBut.Location = new System.Drawing.Point(71, 121);
            this.DekstrBut.Name = "DekstrBut";
            this.DekstrBut.Size = new System.Drawing.Size(165, 43);
            this.DekstrBut.TabIndex = 1;
            this.DekstrBut.Text = "Дейкстра";
            this.DekstrBut.UseVisualStyleBackColor = true;
            this.DekstrBut.Click += new System.EventHandler(this.DekstrBut_Click);
            // 
            // FordBut
            // 
            this.FordBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FordBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FordBut.Location = new System.Drawing.Point(522, 121);
            this.FordBut.Name = "FordBut";
            this.FordBut.Size = new System.Drawing.Size(165, 43);
            this.FordBut.TabIndex = 2;
            this.FordBut.Text = "Форд-Фалкерсон";
            this.FordBut.UseVisualStyleBackColor = true;
            this.FordBut.Click += new System.EventHandler(this.FordBut_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите алгоритм";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 190);
            this.label3.TabIndex = 4;
            this.label3.Text = "Алгори́тм Де́йкстры (англ. Dijkstra\'s algorithm) — алгоритм, который находит крат" +
    "чайшие пути от одной из вершин графа до всех остальных.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(392, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 190);
            this.label4.TabIndex = 5;
            this.label4.Text = "Алгоритм Форда — Фалкерсона решает задачу нахождения максимального потока в транс" +
    "портной сети.";
            // 
            // AllIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FordBut);
            this.Controls.Add(this.DekstrBut);
            this.Controls.Add(this.label1);
            this.Name = "AllIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DekstrBut;
        private System.Windows.Forms.Button FordBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

