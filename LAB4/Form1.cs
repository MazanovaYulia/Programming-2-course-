using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OlympiadSorting
{
    public partial class Form1 : Form
    {
        private int[] NumbersList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] BubbleList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] RapidList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] InsertList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] ShakerList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] BogoList = { 48, 97, 5, 94, 33, 66 };
        private List<Task> _tasks = new List<Task>();
        private CancellationTokenSource cancelTokenSource;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Random_Click(object sender, EventArgs e)
        {
            ClearTable();
            cancelTokenSource = new CancellationTokenSource();

            if (string.IsNullOrEmpty(CountData.Text))
            {
                MessageBox.Show("Поле не может быть пустым");
                return;
            }

            SetRandomArray(int.Parse(CountData.Text));
        }

        private void SetRandomArray(int arrayLength)
        {
            var nums = Enumerable.Range(0, arrayLength).ToArray();
            var rnd = new Random();
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                (nums[randomIndex], nums[i]) = (nums[i], nums[randomIndex]);
            }

            BubbleList = nums.Clone() as int[];
            InsertList = nums.Clone() as int[];
            BogoList = nums.Clone() as int[];
            ShakerList = nums.Clone() as int[];
            RapidList = nums.Clone() as int[];
            NumbersList = nums.Clone() as int[];

            SetList(ChartBubble, BubbleList);
            SetList(ChartRapid, RapidList);
            SetList(ChartInsert, InsertList);
            SetList(ChartBogo, BogoList);
            SetList(ChartShaker, ShakerList);

            ClearTable();

            int RowIndex = 0;
            foreach (var num in nums)
            {
                TableData.Rows.Add();
                TableData.Rows[RowIndex].Cells[0].Value = num.ToString();
                RowIndex++;
            }
        }

        List<int> GetAllPoints()
        {
            List<int> Points = new List<int>();

            for (int RowCount = 0; RowCount < TableData.RowCount; RowCount++)
            {
                try
                {
                    var Row = TableData.Rows[RowCount];
                    var CellValue = Row.Cells[0].EditedFormattedValue;
                    string CellValueLine = CellValue.ToString();
                    int Number = int.Parse(CellValueLine);

                    Points.Add(Number);
                }
                catch
                {
                    continue;
                }
            }

            return Points;
        }

        void UpdateCharts()
        {
            List<int> Points = GetAllPoints();

            BubbleList = Points.ToArray();
            InsertList = Points.ToArray();
            BogoList = Points.ToArray();
            ShakerList = Points.ToArray();
            RapidList = Points.ToArray();
            NumbersList = Points.ToArray();

            SetList(ChartBubble, BubbleList);
            SetList(ChartRapid, RapidList);
            SetList(ChartInsert, InsertList);
            SetList(ChartBogo, BogoList);
            SetList(ChartShaker, ShakerList);
        }

        private void TableAddPoint(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCharts();
        }

        void ClearTable()
        {
            TableData.Rows.Clear();
        }

        private void SetList(Chart chart, int[] list)
        {
            chart.Series.Clear();
            var series = new Series(chart.Name);
            for ((int index, int x) = (0, 0); index < list.Length; index++, x++)
            {
                var height = list[index];
                series.Points.Add(new DataPoint(x, height));
            }

            chart.Series.Add(series);
        }


        private void BubbleSort()
        {
            for (int i = 0; i < BubbleList.Length; i++)
            {
                for (int j = 0; j < BubbleList.Length - 1 - i; j++)
                {
                    if (BubbleList[j] > BubbleList[j + 1])
                    {
                        (BubbleList[j + 1], BubbleList[j]) = (BubbleList[j], BubbleList[j + 1]);
                        Invoke(new Action(() => SetList(ChartBubble, BubbleList)));

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }
            }
        }

        private void BubbleSortReverse()
        {
            for (int i = 0; i < BubbleList.Length; i++)
            {
                for (int j = 0; j < BubbleList.Length - 1 - i; j++)
                {
                    if (BubbleList[j] < BubbleList[j + 1])
                    {
                        (BubbleList[j + 1], BubbleList[j]) = (BubbleList[j], BubbleList[j + 1]);
                        Invoke(new Action(() => SetList(ChartBubble, BubbleList)));

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }
            }
        }

        private void FastSortReverse(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] > pivot)
                {
                    i++;
                }

                while (array[j] < pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    Invoke(new Action(() => SetList(ChartRapid, RapidList)));

                    i++;
                    j--;
                    if (cancelTokenSource.Token.IsCancellationRequested) return;
                }
            }

            if (leftIndex < j)
                FastSortReverse(array, leftIndex, j);

            if (i < rightIndex)
                FastSortReverse(array, i, rightIndex);

            RapidList = array;
        }

        private void FastSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    Invoke(new Action(() => SetList(ChartRapid, RapidList)));

                    i++;
                    j--;
                    if (cancelTokenSource.Token.IsCancellationRequested) return;
                }
            }

            if (leftIndex < j)
                FastSort(array, leftIndex, j);

            if (i < rightIndex)
                FastSort(array, i, rightIndex);

            RapidList = array;
        }

        private void ShakerSort()
        {
            for (var i = 0; i < ShakerList.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < ShakerList.Length - i - 1; j++)
                {
                    if (ShakerList[j] > ShakerList[j + 1])
                    {
                        Swap(ref ShakerList[j], ref ShakerList[j + 1]);
                        Invoke(new Action(() => SetList(ChartShaker, ShakerList)));
                        swapFlag = true;

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }

                for (var j = ShakerList.Length - 2 - i; j > i; j--)
                {
                    if (ShakerList[j - 1] > ShakerList[j])
                    {
                        Swap(ref ShakerList[j - 1], ref ShakerList[j]);
                        Invoke(new Action(() => SetList(ChartShaker, ShakerList)));

                        swapFlag = true;

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
        }

        private void ShakerSortReverse()
        {
            for (var i = 0; i < ShakerList.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < ShakerList.Length - i - 1; j++)
                {
                    if (ShakerList[j] < ShakerList[j + 1])
                    {
                        Swap(ref ShakerList[j], ref ShakerList[j + 1]);
                        Invoke(new Action(() => SetList(ChartShaker, ShakerList)));
                        swapFlag = true;

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }

                for (var j = ShakerList.Length - 2 - i; j > i; j--)
                {
                    if (ShakerList[j - 1] < ShakerList[j])
                    {
                        Swap(ref ShakerList[j - 1], ref ShakerList[j]);
                        Invoke(new Action(() => SetList(ChartShaker, ShakerList)));

                        swapFlag = true;

                        if (cancelTokenSource.Token.IsCancellationRequested) return;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
        }

        private void InsertSort()
        {
            int n = InsertList.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = InsertList[i];
                int j = i - 1;
                while (j >= 0 && InsertList[j] > key)
                {
                    InsertList[j + 1] = InsertList[j];
                    j = j - 1;
                }

                InsertList[j + 1] = key;
                Invoke(new Action(() => SetList(ChartInsert, InsertList)));

                if (cancelTokenSource.Token.IsCancellationRequested) return;
            }
        }

        private void InsertSortReverse()
        {
            int n = InsertList.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = InsertList[i];
                int j = i - 1;
                while (j >= 0 && InsertList[j] < key)
                {
                    InsertList[j + 1] = InsertList[j];
                    j = j - 1;
                }

                InsertList[j + 1] = key;
                Invoke(new Action(() => SetList(ChartInsert, InsertList)));

                if (cancelTokenSource.Token.IsCancellationRequested) return;
            }
        }

        private void BogoSort()
        {
            int[] arr = BogoList;
            while (!IsSorted(arr))
            {
                arr = Shuffle(BogoList);
                Invoke(new Action(() => SetList(ChartBogo, arr)));

                if (cancelTokenSource.Token.IsCancellationRequested) return;
            }
        }

        private void BogoSortReverse()
        {
            int[] arr = BogoList;
            while (!IsSortedReverse(arr))
            {
                arr = Shuffle(BogoList);
                Invoke(new Action(() => SetList(ChartBogo, arr)));

                if (cancelTokenSource.Token.IsCancellationRequested) return;
            }
        }

        static bool IsSorted(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsSortedReverse(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static int[] Shuffle(int[] numbers)
        {
            Random r = new Random();
            for (int n = numbers.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                (numbers[n], numbers[k]) = (numbers[k], numbers[n]);
            }
            return numbers;
        }

        private void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
            BubbleTimer.Text = "";
            InsertTimer.Text = "";
            ShakerTimer.Text = "";
            RapidTimer.Text = "";
            BogoTimer.Text = "";
            Bubble.Checked = false;
            Insert.Checked = false;
            Shaker.Checked = false;
            Rapid.Checked = false;
            Bogo.Checked = false;
            ClearTable();
            UpdateCharts();
        }

        private void CountData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void DrawCharts()
        {
            SetList(ChartBubble, BubbleList);
            SetList(ChartRapid, RapidList);
            SetList(ChartInsert, InsertList);
            SetList(ChartBogo, BogoList);
            SetList(ChartShaker, ShakerList);
        }

        private async void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BubbleList.Length == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну точку!");
                return;
            }

            try { cancelTokenSource.Cancel(); } catch { }

            BubbleList = NumbersList.ToArray();
            InsertList = NumbersList.ToArray();
            BogoList = NumbersList.ToArray();
            ShakerList = NumbersList.ToArray();
            RapidList = NumbersList.ToArray();
            DrawCharts();
            cancelTokenSource = new CancellationTokenSource();

            if (Bubble.Checked)
            {
                var timer = new Stopwatch();
                Task task;
                timer.Start();

                if (!ReverseCheck.Checked)
                {
                    task = Task.Run(BubbleSort);
                }
                else
                {
                    task = Task.Run(BubbleSortReverse);
                }
                _tasks.Add(task);
                await task;

                timer.Stop();
                BubbleTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Bubble.Checked == false)
            {
                BubbleTimer.Text = "";
            }

            if (Shaker.Checked)
            {
                var timer = new Stopwatch();
                Task task;
                timer.Start();

                if (!ReverseCheck.Checked)
                {
                    task = Task.Run(ShakerSort);
                }
                else
                {
                    task = Task.Run(ShakerSortReverse);
                }
                _tasks.Add(task);
                await task;

                timer.Stop();
                ShakerTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Shaker.Checked == false)
            {
                ShakerTimer.Text = "";
            }

            if (Rapid.Checked)
            {
                var timer = new Stopwatch();
                Task task;
                timer.Start();

                if (!ReverseCheck.Checked)
                {
                    task = Task.Run(() => FastSort(RapidList, 0, RapidList.Length - 1));
                }
                else
                {
                    task = Task.Run(() => FastSortReverse(RapidList, 0, RapidList.Length - 1));
                }
                _tasks.Add(task);
                await task;

                timer.Stop();
                RapidTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Rapid.Checked == false)
            {
                RapidTimer.Text = "";
            }

            if (Insert.Checked)
            {
                var timer = new Stopwatch();
                Task task;
                timer.Start();

                if (!ReverseCheck.Checked)
                {
                    task = Task.Run(InsertSort);
                }
                else
                {
                    task = Task.Run(InsertSortReverse);
                }
                _tasks.Add(task);
                await task;

                timer.Stop();
                InsertTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Insert.Checked == false)
            {
                InsertTimer.Text = "";
            }

            if (Bogo.Checked)
            {
                var timer = new Stopwatch();
                Task task;
                timer.Start();

                if (!ReverseCheck.Checked)
                {
                    task = Task.Run(BogoSort);
                }
                else
                {
                    task = Task.Run(BogoSortReverse);
                }
                _tasks.Add(task);
                await task;

                timer.Stop();
                BogoTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Bogo.Checked == false)
            {
                BogoTimer.Text = "";
            }
        }
    }
}
