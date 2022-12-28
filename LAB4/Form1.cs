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
        private int[] BubbleList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] RapidList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] InsertList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] ShakerList = { 48, 97, 5, 94, 33, 66, 74, 6, 21, 91, 28, 31 };
        private int[] BogoList = { 48, 97, 5, 94, 33, 66 };
        private readonly List<Task> Tasks = new List<Task>();
        private CancellationTokenSource cancelTokenSource;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Random_Click(object sender, EventArgs e)
        {
            cancelTokenSource = new CancellationTokenSource();

            if (string.IsNullOrEmpty(CountData.Text))
            {
                MessageBox.Show("Поле не может быть пустым");
                return;
            }
            SetRandomArray(int.Parse(CountData.Text));

            if (Bubble.Checked)
            {
                var timer = new Stopwatch();
                timer.Start();

                var task = Task.Run(BubbleSort);
                Tasks.Add(task);
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
                timer.Start();

                var task = Task.Run(ShakerSort);
                Tasks.Add(task);
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
                timer.Start();

                var task = Task.Run(() => FastSort(RapidList, 0, RapidList.Length - 1));
                Tasks.Add(task);
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
                timer.Start();

                var task = Task.Run(InsertSort);
                Tasks.Add(task);
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
                timer.Start();

                var task = Task.Run(BogoSort);
                Tasks.Add(task);
                await task;

                timer.Stop();
                BogoTimer.Text = timer.ElapsedMilliseconds + " мс";
            }
            if (Bogo.Checked == false)
            {
                BogoTimer.Text = "";
            }
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

            SetList(ChartBubble, BubbleList);
            SetList(ChartRapid, RapidList);
            SetList(ChartInsert, InsertList);
            SetList(ChartBogo, BogoList);
            SetList(ChartShaker, ShakerList);
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
                    j--;
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
            ChartBubble.Series.Clear();
            ChartShaker.Series.Clear();
            ChartInsert.Series.Clear();
            ChartRapid.Series.Clear();
            ChartBogo.Series.Clear();
            CountData.Text = "";
            TableData.Rows.Clear();
        }

        private void CountData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
