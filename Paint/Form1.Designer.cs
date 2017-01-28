namespace Paint
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cBox_FiguraType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_form = new System.Windows.Forms.ProgressBar();
            this.btn_invert = new System.Windows.Forms.Button();
            this.pb_figurColor = new System.Windows.Forms.PictureBox();
            this.btn_figurColor = new System.Windows.Forms.Button();
            this.pb_backColor = new System.Windows.Forms.PictureBox();
            this.btn_backColor = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.colorDialogForFigura = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_figurColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backColor)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AllowDrop = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(679, 665);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragDrop);
            this.mainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainPanel_DragEnter);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // cBox_FiguraType
            // 
            this.cBox_FiguraType.FormattingEnabled = true;
            this.cBox_FiguraType.Items.AddRange(new object[] {
            "Произвольное рисование",
            "Линия",
            "Прямоугольник\\Квадрат",
            "Круг"});
            this.cBox_FiguraType.Location = new System.Drawing.Point(12, 9);
            this.cBox_FiguraType.Name = "cBox_FiguraType";
            this.cBox_FiguraType.Size = new System.Drawing.Size(207, 21);
            this.cBox_FiguraType.TabIndex = 0;
            this.cBox_FiguraType.Text = "Произвольное рисование";
            this.cBox_FiguraType.DropDownClosed += new System.EventHandler(this.cBox_FiguraType_DropDownClosed);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42565F));
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 671);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pb_form);
            this.panel1.Controls.Add(this.btn_invert);
            this.panel1.Controls.Add(this.pb_figurColor);
            this.panel1.Controls.Add(this.btn_figurColor);
            this.panel1.Controls.Add(this.pb_backColor);
            this.panel1.Controls.Add(this.btn_backColor);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.cBox_FiguraType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(688, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 665);
            this.panel1.TabIndex = 1;
            // 
            // pb_form
            // 
            this.pb_form.Location = new System.Drawing.Point(12, 216);
            this.pb_form.Name = "pb_form";
            this.pb_form.Size = new System.Drawing.Size(207, 23);
            this.pb_form.TabIndex = 8;
            // 
            // btn_invert
            // 
            this.btn_invert.Location = new System.Drawing.Point(12, 186);
            this.btn_invert.Name = "btn_invert";
            this.btn_invert.Size = new System.Drawing.Size(95, 23);
            this.btn_invert.TabIndex = 7;
            this.btn_invert.Text = "Инвертировать";
            this.btn_invert.UseVisualStyleBackColor = true;
            this.btn_invert.Click += new System.EventHandler(this.btn_invert_Click);
            // 
            // pb_figurColor
            // 
            this.pb_figurColor.BackColor = System.Drawing.Color.Black;
            this.pb_figurColor.Location = new System.Drawing.Point(12, 65);
            this.pb_figurColor.Name = "pb_figurColor";
            this.pb_figurColor.Size = new System.Drawing.Size(58, 23);
            this.pb_figurColor.TabIndex = 6;
            this.pb_figurColor.TabStop = false;
            // 
            // btn_figurColor
            // 
            this.btn_figurColor.Location = new System.Drawing.Point(85, 65);
            this.btn_figurColor.Name = "btn_figurColor";
            this.btn_figurColor.Size = new System.Drawing.Size(75, 23);
            this.btn_figurColor.TabIndex = 5;
            this.btn_figurColor.Text = "Цвет фигур";
            this.btn_figurColor.UseVisualStyleBackColor = true;
            this.btn_figurColor.Click += new System.EventHandler(this.btn_figurColor_Click);
            // 
            // pb_backColor
            // 
            this.pb_backColor.BackColor = System.Drawing.Color.White;
            this.pb_backColor.Location = new System.Drawing.Point(12, 36);
            this.pb_backColor.Name = "pb_backColor";
            this.pb_backColor.Size = new System.Drawing.Size(58, 23);
            this.pb_backColor.TabIndex = 4;
            this.pb_backColor.TabStop = false;
            // 
            // btn_backColor
            // 
            this.btn_backColor.Location = new System.Drawing.Point(85, 36);
            this.btn_backColor.Name = "btn_backColor";
            this.btn_backColor.Size = new System.Drawing.Size(75, 23);
            this.btn_backColor.TabIndex = 3;
            this.btn_backColor.Text = "Цвет фона";
            this.btn_backColor.UseVisualStyleBackColor = true;
            this.btn_backColor.Click += new System.EventHandler(this.btn_backColor_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 144);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(935, 709);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_figurColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox cBox_FiguraType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_figurColor;
        private System.Windows.Forms.Button btn_figurColor;
        private System.Windows.Forms.PictureBox pb_backColor;
        private System.Windows.Forms.Button btn_backColor;
        private System.Windows.Forms.ColorDialog colorDialogForFigura;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.Button btn_invert;
        private System.Windows.Forms.ProgressBar pb_form;
    }
}

