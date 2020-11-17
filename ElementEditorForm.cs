using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ElementEditorForm : Form
    {
        private Element _element = null;
        public Element EditableElement { get => _element; }

        public ElementEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Element editableElement)
        {
            if (editableElement == null)
                _element = new Element() { LeadTime = DateTime.Now };
            else
                _element = editableElement;

            taskTextBox.Text = editableElement.Task;
            leadTimeDateTimePicker.Value = editableElement.LeadTime;

            return this.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_element == null)
                _element = new Element { LeadTime = DateTime.Now };

            _element.Task = taskTextBox.Text;
            _element.LeadTime = leadTimeDateTimePicker.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
