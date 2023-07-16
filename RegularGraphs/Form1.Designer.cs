namespace RegularGraphs
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
            this.numericNodeCount = new System.Windows.Forms.NumericUpDown();
            this.numericConnectivity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ололоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНесвязныеГрафыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьДиаметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericNodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnectivity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericNodeCount
            // 
            this.numericNodeCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericNodeCount.Location = new System.Drawing.Point(225, 57);
            this.numericNodeCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericNodeCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericNodeCount.Name = "numericNodeCount";
            this.numericNodeCount.Size = new System.Drawing.Size(57, 35);
            this.numericNodeCount.TabIndex = 0;
            this.numericNodeCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericConnectivity
            // 
            this.numericConnectivity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericConnectivity.Location = new System.Drawing.Point(225, 108);
            this.numericConnectivity.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericConnectivity.Name = "numericConnectivity";
            this.numericConnectivity.Size = new System.Drawing.Size(57, 35);
            this.numericConnectivity.TabIndex = 1;
            this.numericConnectivity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во вершин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Степень вершин:";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.Location = new System.Drawing.Point(13, 166);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(968, 437);
            this.richTextBoxResult.TabIndex = 4;
            this.richTextBoxResult.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ололоToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.удалитьНесвязныеГрафыToolStripMenuItem,
            this.рассчитатьДиаметрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ололоToolStripMenuItem
            // 
            this.ололоToolStripMenuItem.Name = "ололоToolStripMenuItem";
            this.ололоToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.ололоToolStripMenuItem.Text = "Справка";
            this.ололоToolStripMenuItem.Click += new System.EventHandler(this.ололоToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.справкаToolStripMenuItem.Text = "Сгенерировать регулярные графы";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // удалитьНесвязныеГрафыToolStripMenuItem
            // 
            this.удалитьНесвязныеГрафыToolStripMenuItem.Name = "удалитьНесвязныеГрафыToolStripMenuItem";
            this.удалитьНесвязныеГрафыToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.удалитьНесвязныеГрафыToolStripMenuItem.Text = "Удалить несвязные графы";
            this.удалитьНесвязныеГрафыToolStripMenuItem.Click += new System.EventHandler(this.удалитьНесвязныеГрафыToolStripMenuItem_Click);
            // 
            // рассчитатьДиаметрыToolStripMenuItem
            // 
            this.рассчитатьДиаметрыToolStripMenuItem.Name = "рассчитатьДиаметрыToolStripMenuItem";
            this.рассчитатьДиаметрыToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.рассчитатьДиаметрыToolStripMenuItem.Text = "Рассчитать диаметры";
            this.рассчитатьДиаметрыToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьДиаметрыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 622);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericConnectivity);
            this.Controls.Add(this.numericNodeCount);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Исследование диаметров связных регулярных графов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNodeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConnectivity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericNodeCount;
        private System.Windows.Forms.NumericUpDown numericConnectivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ололоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНесвязныеГрафыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьДиаметрыToolStripMenuItem;
    }
}

