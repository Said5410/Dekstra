namespace MainAll
{
    partial class MaxThreadForm
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
            this.ClearBut = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.node2Comp = new System.Windows.Forms.NumericUpDown();
            this.node1Comp = new System.Windows.Forms.NumericUpDown();
            this.node2Label = new System.Windows.Forms.Label();
            this.node1Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveBut = new System.Windows.Forms.Button();
            this.loadBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.node2Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.node1Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(679, 163);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(130, 23);
            this.ClearBut.TabIndex = 29;
            this.ClearBut.Text = "Очистить";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(679, 76);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 28;
            this.resultButton.Text = "Вычислить";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(679, 114);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(124, 13);
            this.resultLabel.TabIndex = 27;
            this.resultLabel.Text = "Максимальный поток: ";
            // 
            // node2Comp
            // 
            this.node2Comp.Location = new System.Drawing.Point(746, 45);
            this.node2Comp.Name = "node2Comp";
            this.node2Comp.Size = new System.Drawing.Size(44, 20);
            this.node2Comp.TabIndex = 26;
            // 
            // node1Comp
            // 
            this.node1Comp.Location = new System.Drawing.Point(746, 19);
            this.node1Comp.Name = "node1Comp";
            this.node1Comp.Size = new System.Drawing.Size(44, 20);
            this.node1Comp.TabIndex = 25;
            // 
            // node2Label
            // 
            this.node2Label.AutoSize = true;
            this.node2Label.Location = new System.Drawing.Point(676, 47);
            this.node2Label.Name = "node2Label";
            this.node2Label.Size = new System.Drawing.Size(64, 13);
            this.node2Label.TabIndex = 24;
            this.node2Label.Text = "Вершина 2:";
            // 
            // node1Label
            // 
            this.node1Label.AutoSize = true;
            this.node1Label.Location = new System.Drawing.Point(676, 21);
            this.node1Label.Name = "node1Label";
            this.node1Label.Size = new System.Drawing.Size(64, 13);
            this.node1Label.TabIndex = 23;
            this.node1Label.Text = "Вершина 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 519);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(676, 438);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(137, 23);
            this.saveBut.TabIndex = 30;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // loadBut
            // 
            this.loadBut.Location = new System.Drawing.Point(676, 467);
            this.loadBut.Name = "loadBut";
            this.loadBut.Size = new System.Drawing.Size(137, 23);
            this.loadBut.TabIndex = 31;
            this.loadBut.Text = "Загрузить";
            this.loadBut.UseVisualStyleBackColor = true;
            this.loadBut.Click += new System.EventHandler(this.openBut_Click);
            // 
            // MaxThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 553);
            this.Controls.Add(this.loadBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.node2Comp);
            this.Controls.Add(this.node1Comp);
            this.Controls.Add(this.node2Label);
            this.Controls.Add(this.node1Label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MaxThreadForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaxThreadForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.node2Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.node1Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.NumericUpDown node2Comp;
        private System.Windows.Forms.NumericUpDown node1Comp;
        private System.Windows.Forms.Label node2Label;
        private System.Windows.Forms.Label node1Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button loadBut;
    }
}