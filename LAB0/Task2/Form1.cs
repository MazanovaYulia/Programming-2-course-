using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LAB0_task2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawTable();
        }
        void DrawTable()
        {
            TableData.ColumnCount = 4;

            using (TextFieldParser parser = new TextFieldParser("data.csv", Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                int RowIndex = 0;

                while (!parser.EndOfData)
                {
                    TableData.Rows.Add();
                    int ColumnIndex = 0;
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        TableData.Rows[RowIndex].Cells[ColumnIndex].Value = field;
                        ColumnIndex += 1;
                    }
                    RowIndex += 1;
                }
            }
        }
        void SearchTable(string StMark, string StGroup)
        {
            TableData.ColumnCount = 4;

            using (TextFieldParser parser = new TextFieldParser("data.csv", Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                int RowIndex = 0;

                while (!parser.EndOfData)
                {
                    TableData.Rows.Add();
                    int ColumnIndex = 0;
                    string[] fields = parser.ReadFields();

                    string RowGroup = fields[2];
                    string RowMark = fields[3];

                    if (StMark != "" && StMark != RowMark)
                    {
                        continue;
                    }

                    if (StGroup != "" && StGroup != RowGroup)
                    {
                        continue;
                    }

                    foreach (string field in fields)
                    {
                        TableData.Rows[RowIndex].Cells[ColumnIndex].Value = field;
                        ColumnIndex += 1;
                    }
                    RowIndex += 1;
                }
            }
        }
        void DeleteTable()
        {
            TableData.Rows.Clear();
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            string StSurname = Surname.Text;
            string StName = FirstName.Text;
            string StGroup = Group.Text;
            string StMark = Mark.Text;
            Surname.MaxLength = 55;
            FirstName.MaxLength = 55;
            Group.MaxLength = 20;
            Mark.MaxLength = 1;

            if (Surname.Text == "" || FirstName.Text == "" || Group.Text == "" || Mark.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми.");
                return;
            }

            using (var w = new StreamWriter("data.csv", true))
            {
                string line = string.Format("{0};{1};{2};{3}", StSurname, StName, StGroup, StMark);
                w.WriteLine(line);
            }
            DeleteTable();
            DrawTable();
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            string StMark = FilterMark.Text;
            string StGroup = FilterGroup.Text;
            Group.MaxLength = 20;
            Mark.MaxLength = 1;

            DeleteTable();
            SearchTable(StMark, StGroup);
        }
        private void Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        private void Mark_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Mark.Text, out int CalMark))
            {
                Convert.ToInt32(Mark.Text);
                int CalculMark = CalMark;
                
                if (CalculMark >= 2 && CalculMark <= 5)
                {
                }
                else
                {
                    MessageBox.Show("Неправильный формат ввода оценки. Укажите оценку 2, 3, 4 или 5.\n\n(2 - неудовлетворительно, 3 - удовлетворительно, 4 - хорошо, 5 - отлично)");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неправильный формат ввода оценки. Укажите оценку 2, 3, 4 или 5.\n\n(2 - неудовлетворительно, 3 - удовлетворительно, 4 - хорошо, 5 - отлично)");
                return;
            }
        }
        private void ResetFilter_Click(object sender, EventArgs e)
        {
            DeleteTable();
            DrawTable();
            FilterGroup.Clear();
            FilterMark.Clear();
        }
    }
}
