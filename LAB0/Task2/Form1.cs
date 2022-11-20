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
            foreach (DataGridViewColumn column in TableData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Surname.MaxLength = 55;
            FirstName.MaxLength = 55;
            Group.MaxLength = 20;
            Mark.MaxLength = 1;
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
            bool RowIsFind = false;

            using (TextFieldParser parser = new TextFieldParser("data.csv", Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                int RowIndex = 0;

                while (!parser.EndOfData)
                {
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

                    TableData.Rows.Add();
                    RowIsFind = true;
                    foreach (string field in fields)
                    {
                        TableData.Rows[RowIndex].Cells[ColumnIndex].Value = field;
                        ColumnIndex += 1;
                    }
                    RowIndex += 1;
                    for (int k = 0; k < TableData.Rows.Count; k++)
                    {
                        if (TableData.Rows[k].Cells[1].Value == null)
                        {
                            TableData.Rows.RemoveAt(k);
                        }
                    }
              
                    for (int i = 1; i < TableData.RowCount - 1; i++)

                    {
                        if (TableData.Rows[i].Cells[0].Value.ToString() == "" || TableData.Rows[i].Cells[1].Value.ToString() == "")

                        {

                            TableData.Rows.RemoveAt(i);
                            i--;
                        }

                    }
                }
                
            }

            if (!RowIsFind)
            {
                MessageBox.Show("Совпадений не найдено!");
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
            if ((e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 96 || e.KeyChar >= 123) && e.KeyChar != 45 && e.KeyChar != 8 && e.KeyChar != 39 && (e.KeyChar <= 'А' || e.KeyChar >= 'я') && e.KeyChar != 'ё' && e.KeyChar != 'Ё' && e.KeyChar != 'А' && e.KeyChar != 'я')
            {
                e.Handled = true;
            }
        }
        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 96 || e.KeyChar >= 123) && e.KeyChar != 45 && e.KeyChar != 8 && e.KeyChar != 39 && (e.KeyChar <= 'А' || e.KeyChar >= 'я') && e.KeyChar != 'ё' && e.KeyChar != 'Ё' && e.KeyChar != 'А' && e.KeyChar != 'я')
            {
                e.Handled = true;
            }
        }
        private void ResetFilter_Click(object sender, EventArgs e)
        {
            DeleteTable();
            DrawTable();
            FilterGroup.Clear();
            FilterMark.Clear();
        }
        private void Group_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 64 || e.KeyChar >= 91) && (e.KeyChar <= 96 || e.KeyChar >= 123) && e.KeyChar != 45 && e.KeyChar != 8 && (e.KeyChar <= 'А' || e.KeyChar >= 'я') && e.KeyChar != 'ё' && e.KeyChar != 'Ё')
            {
                e.Handled = true;
            }
        }

        private void Mark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 49 || e.KeyChar >= 54) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
