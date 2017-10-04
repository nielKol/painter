namespace SuperPaint
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
            this.statusBar1 = new SuperPaint.UserControls.StatusBar();
            this.tabsControlWithButtons1 = new SuperPaint.UserControls.TabsControlWithButtons();
            this.toolBoxFigureFromPlagins1 = new SuperPaint.UserControls.ToolBoxFigureFromPlagins();
            this.toolBoxSaveLoad1 = new SuperPaint.UserControls.ToolBoxSaveLoad();
            this.menu1 = new SuperPaint.Menu();
            this.toolBar1 = new SuperPaint.UserControls.ToolBar();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 431);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(972, 25);
            this.statusBar1.TabIndex = 2;
            // 
            // tabsControlWithButtons1
            // 
            this.tabsControlWithButtons1.Location = new System.Drawing.Point(170, 51);
            this.tabsControlWithButtons1.Name = "tabsControlWithButtons1";
            this.tabsControlWithButtons1.Size = new System.Drawing.Size(585, 374);
            this.tabsControlWithButtons1.TabIndex = 3;
            // 
            // toolBoxFigureFromPlagins1
            // 
            this.toolBoxFigureFromPlagins1.Location = new System.Drawing.Point(11, 60);
            this.toolBoxFigureFromPlagins1.Name = "toolBoxFigureFromPlagins1";
            this.toolBoxFigureFromPlagins1.Size = new System.Drawing.Size(153, 365);
            this.toolBoxFigureFromPlagins1.TabIndex = 4;
            // 
            // toolBoxSaveLoad1
            // 
            this.toolBoxSaveLoad1.Location = new System.Drawing.Point(761, 274);
            this.toolBoxSaveLoad1.Name = "toolBoxSaveLoad1";
            this.toolBoxSaveLoad1.Size = new System.Drawing.Size(213, 151);
            this.toolBoxSaveLoad1.TabIndex = 5;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, -1);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(972, 26);
            this.menu1.TabIndex = 6;
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(0, 19);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(972, 26);
            this.toolBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 459);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.toolBoxSaveLoad1);
            this.Controls.Add(this.toolBoxFigureFromPlagins1);
            this.Controls.Add(this.tabsControlWithButtons1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Form1";
            this.Text = "Painter";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.StatusBar statusBar1;
        private UserControls.TabsControlWithButtons tabsControlWithButtons1;
        private UserControls.ToolBoxFigureFromPlagins toolBoxFigureFromPlagins1;
        private UserControls.ToolBoxSaveLoad toolBoxSaveLoad1;
        private Menu menu1;
        private UserControls.ToolBar toolBar1;
    }
}

