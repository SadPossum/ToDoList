
namespace ToDoList
{
    partial class ElementEditorForm
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
            this.bottomMenuPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.leadTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bottomMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomMenuPanel
            // 
            this.bottomMenuPanel.Controls.Add(this.cancelButton);
            this.bottomMenuPanel.Controls.Add(this.saveButton);
            this.bottomMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.bottomMenuPanel.Name = "bottomMenuPanel";
            this.bottomMenuPanel.Size = new System.Drawing.Size(296, 64);
            this.bottomMenuPanel.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(147, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 64);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(0, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 64);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskTextBox.Location = new System.Drawing.Point(0, 0);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(296, 22);
            this.taskTextBox.TabIndex = 4;
            // 
            // leadTimeDateTimePicker
            // 
            this.leadTimeDateTimePicker.CustomFormat = "dd:MM:yy   HH:mm";
            this.leadTimeDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.leadTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.leadTimeDateTimePicker.Location = new System.Drawing.Point(0, 22);
            this.leadTimeDateTimePicker.Name = "leadTimeDateTimePicker";
            this.leadTimeDateTimePicker.Size = new System.Drawing.Size(296, 22);
            this.leadTimeDateTimePicker.TabIndex = 5;
            // 
            // ElementEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 109);
            this.Controls.Add(this.leadTimeDateTimePicker);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.bottomMenuPanel);
            this.Name = "ElementEditorForm";
            this.Text = "ElementEditorForm";
            this.bottomMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottomMenuPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.DateTimePicker leadTimeDateTimePicker;
    }
}