using System;
using System.IO;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        private string filePath = "Tasks.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                StreamReader reader = new StreamReader(fStream);

                while (!reader.EndOfStream)
                {
                    string[] text = reader.ReadLine().Split(new[] { "-_-" }, StringSplitOptions.RemoveEmptyEntries);

                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = text[0];
                    item.SubItems.Add(text[1]);
                    elementsListView.Items.Add(item);
                }
            }
        }

        private void DataRefresh()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (ListViewItem item in elementsListView.Items)
                {
                    string line = $"{item.SubItems[0].Text}-_-{item.SubItems[1].Text}";

                    writer.WriteLine(line);
                }

                writer.Flush();
            }
        }

        private void elementEditorButton_Click(object sender, EventArgs e)
        {
            ElementEditorForm elementEditor = new ElementEditorForm();
            var result = elementEditor.ShowDialog();
            Element newElement = elementEditor.EditableElement;

            if(result == DialogResult.OK)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.SubItems[0].Text = newElement.Task;
                newItem.SubItems.Add(newElement.LeadTime.ToString());
                elementsListView.Items.Add(newItem);
                DataRefresh();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (elementsListView.SelectedItems.Count < 1)
                return;

            ListViewItem selectItem = elementsListView.SelectedItems[0];
            elementsListView.Items.Remove(selectItem);
            DataRefresh();
        }

        private void elementsListView_DoubleClick(object sender, EventArgs e)
        {
            if (elementsListView.SelectedItems.Count < 1)
                return;

            ListViewItem selectedItem = elementsListView.SelectedItems[0];

            Element editableElement = new Element
            {
                Task = selectedItem.SubItems[0].Text,
                LeadTime = DateTime.Parse(selectedItem.SubItems[1].Text)
            };

            ElementEditorForm elementEditor = new ElementEditorForm();

            var res = elementEditor.ShowDialog(editableElement);

            if (res == DialogResult.OK)
            {
                selectedItem.SubItems[0].Text = editableElement.Task;
                selectedItem.SubItems[1].Text = editableElement.LeadTime.ToString();
                DataRefresh();
            }
        }
    }
}
