using System;
using System.IO;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private string filePath = "Tasks.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                StreamReader reader = new StreamReader(fStream);

                for (int i = 0; !reader.EndOfStream; i++)
                {
                    tasksListBox.Items.Add(reader.ReadLine());
                }
            }
        }

        private void DataRefresh(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < tasksListBox.Items.Count; i++)
                {
                    writer.WriteLine(tasksListBox.Items[i]);
                }
                writer.Flush();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex > -1)
            {
                tasksListBox.Items.Add(TaskTextBox.Text);
                DataRefresh(filePath);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex > -1)
            {
                tasksListBox.Items.RemoveAt(tasksListBox.SelectedIndex);
                DataRefresh(filePath);
            }
        }
    }
}
