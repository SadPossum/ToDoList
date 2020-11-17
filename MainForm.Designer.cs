namespace ToDoList
{
    partial class MainForm
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
            this.elementEditorButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bottomMenuPanel = new System.Windows.Forms.Panel();
            this.elementsListView = new System.Windows.Forms.ListView();
            this.tasks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leadTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottomMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementEditorButton
            // 
            this.elementEditorButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.elementEditorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.elementEditorButton.FlatAppearance.BorderSize = 0;
            this.elementEditorButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.elementEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elementEditorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementEditorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.elementEditorButton.Location = new System.Drawing.Point(0, 0);
            this.elementEditorButton.Name = "elementEditorButton";
            this.elementEditorButton.Size = new System.Drawing.Size(186, 64);
            this.elementEditorButton.TabIndex = 0;
            this.elementEditorButton.Text = "add";
            this.elementEditorButton.UseVisualStyleBackColor = false;
            this.elementEditorButton.Click += new System.EventHandler(this.elementEditorButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(185, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(186, 64);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bottomMenuPanel
            // 
            this.bottomMenuPanel.Controls.Add(this.deleteButton);
            this.bottomMenuPanel.Controls.Add(this.elementEditorButton);
            this.bottomMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenuPanel.Location = new System.Drawing.Point(0, 363);
            this.bottomMenuPanel.Name = "bottomMenuPanel";
            this.bottomMenuPanel.Size = new System.Drawing.Size(371, 64);
            this.bottomMenuPanel.TabIndex = 2;
            // 
            // elementsListView
            // 
            this.elementsListView.BackColor = System.Drawing.SystemColors.Window;
            this.elementsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasks,
            this.leadTime});
            this.elementsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementsListView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.elementsListView.FullRowSelect = true;
            this.elementsListView.GridLines = true;
            this.elementsListView.HideSelection = false;
            this.elementsListView.Location = new System.Drawing.Point(0, 0);
            this.elementsListView.MultiSelect = false;
            this.elementsListView.Name = "elementsListView";
            this.elementsListView.Size = new System.Drawing.Size(371, 363);
            this.elementsListView.TabIndex = 3;
            this.elementsListView.UseCompatibleStateImageBehavior = false;
            this.elementsListView.View = System.Windows.Forms.View.Details;
            this.elementsListView.DoubleClick += new System.EventHandler(this.elementsListView_DoubleClick);
            // 
            // tasks
            // 
            this.tasks.Text = "Tasks";
            // 
            // leadTime
            // 
            this.leadTime.Text = "Lead Time";
            this.leadTime.Width = 124;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 427);
            this.Controls.Add(this.elementsListView);
            this.Controls.Add(this.bottomMenuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottomMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elementEditorButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel bottomMenuPanel;
        private System.Windows.Forms.ListView elementsListView;
        private System.Windows.Forms.ColumnHeader tasks;
        private System.Windows.Forms.ColumnHeader leadTime;
    }
}

