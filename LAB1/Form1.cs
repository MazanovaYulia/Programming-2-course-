using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dihtomia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double TruncateDecimal(double Value, int Precision)
        {
            double Step = (double)Math.Pow(10, Precision);
            double Temp = Math.Truncate(Step * Value);
            return Temp / Step;
        }
        void DrawChart(List<List<double>> Points, List<List<double>> MinimumPoints)
        {
            foreach (List<double> Point in Points)
            {
                if (Point[0] > 99999999 || Point[0] < -99999999 || Point[1] > 99999999 || Point[1] < -99999999 || Point[1] is double.NaN)
                {
                    continue;
                }
                else
                {
                    Chart.Series[0].Points.AddXY(Point[0], Point[1]);
                }
            }
            foreach (List<double> MinimumPoint in MinimumPoints)
            {
                Chart.Series[1].Points.AddXY(MinimumPoint[0], MinimumPoint[1]);
            }

            Chart.Series[0].Points.ResumeUpdates();
            Chart.Series[1].Points.ResumeUpdates();
        }

        List<double> GetPoint(MathParser Parser, string Function, double X)
        {
            List<double> Point = new List<double>();
            string NowFunction = String.Copy(Function).ToLower();
            NowFunction = NowFunction.Replace("x", X.ToString());

            double Y = Parser.Parse(NowFunction, true);

            Point.Add(X);
            Point.Add(Math.Round(Y, 8));

            return Point;
        }

        List<List<double>> GetMinimumPoints(List<List<double>> Points, List<double> MinimumPoint, double Step)
        {
            List<List<double>> MinimumPoints = new List<List<double>>();

            double LastMinimumPointX = -999999;
            foreach (List<double> Point in Points)
            {
                double DiffX = Math.Abs(Point[0] - LastMinimumPointX);
                double DiffY = Math.Abs(Point[1] - MinimumPoint[1]);
                if (DiffY < 0.001)
                {
                    LastMinimumPointX = Point[0];
                    MinimumPoints.Add(Point);
                }
            }

            return MinimumPoints;
        }

        List<double> GetMinimumPoint(MathParser Parser, string Function, double Start, double End, int Accuracy)
        {
            double Y = 0;
            double X = 0;
            double Precision = 1 / Math.Pow(10, Accuracy);
            double Length = Precision / 2 - Precision / 4;

            do
            {
                X = (Start + End) / 2;
                double StartX = X - Length;
                double EndX = X + Length;
                double StartY = GetPoint(Parser, Function, StartX)[1];
                double EndY = GetPoint(Parser, Function, EndX)[1];

                if (StartY is double.NaN)
                {
                    StartY = 0;
                }

                if (EndY is double.NaN)
                {
                    EndY = 0;
                }

                Y = GetPoint(Parser, Function, X)[1];

                if (StartY <= EndY)
                {
                    End = EndX;
                }
                else if (StartY > EndY)
                {
                    Start = StartX;
                }
            } while (Math.Abs(Start - End) >= Precision);

            List<double> MinimumPoint = new List<double>();
            MinimumPoint.Add(X);
            MinimumPoint.Add(Y);

            return MinimumPoint;
        }

        List<List<double>> GetPoints(MathParser Parser, string Function, double Start, double End, double AmountPoints)
        {
            List<List<double>> Points = new List<List<double>>();
            List<double> XPoints = new List<double>();
            double X = Start;
            double Step = (End - Start) / AmountPoints;

            while (X <= End)
            {
                List<double> Point = GetPoint(Parser, Function, X);
                X = Math.Round(X + Step, 4);
                if (Point[1] is double.NaN)
                {
                    continue;
                }
                Points.Add(Point);
                XPoints.Add(X);
            }

            if (!XPoints.Contains(End))
            {
                List<double> Point = GetPoint(Parser, Function, End);
                Points.Add(Point);
                XPoints.Add(End);
            }

            return Points;
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();

            string Function = FunctionBox.Text.Replace("x", "(x)");
            bool StartInterval = CheckDouble(StartABox.Text, "a");
            bool EndInterval = CheckDouble(EndBBox.Text, "b");
            bool AccuracyOn = CheckInt(AccuracyBox.Text, "e");
            bool FormulaOn = true;

            MathParser Parser = new MathParser();
            try
            {
                List<double> TestPoint = GetPoint(Parser, Function, 1);
            }
            catch
            {
                MessageBox.Show($"Ошибка в формуле");
                FormulaOn = false;
            }

            if (StartInterval && EndInterval && AccuracyOn && FormulaOn)
            {
                double Start = Double.Parse(StartABox.Text);
                double End = Double.Parse(EndBBox.Text);
                int Accuracy = Int32.Parse(AccuracyBox.Text);
                double AmountPoints = 10000;

                if (End > Start)
                {
                    try
                    {
                        List<List<double>> Points = GetPoints(Parser, Function, Start, End, AmountPoints);

                        List<double> MinumumPoint = GetMinimumPoint(Parser, Function, Start, End, Accuracy);
                        double Step = (End - Start) / AmountPoints;
                        List<List<double>> AllMinimumPoints = GetMinimumPoints(Points, MinumumPoint, Step);

                        DrawChart(Points, AllMinimumPoints);

                        if (MinumumPoint[1] is double.NaN)
                        {
                            ResultLabel.Text = $"Минимум не найден";
                        }
                        else
                        {
                            ResultLabel.Text = $"Минимум:\n ( {MinumumPoint[0]}, {TruncateDecimal(MinumumPoint[1], Accuracy)} )";
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Слишком сложная формула");
                    }
                }
                else
                {
                    MessageBox.Show($"Конец интервала не может быть меньше начала интервала");
                }
            }
        }
        bool CheckDouble(string DoubleLine, string DoubleName)
        {
            if (Double.TryParse(DoubleLine, out double DoubleNumber))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Неподходящий формат: {DoubleName}");
                return false;
            }
        }

        bool CheckInt(string IntLine, string IntName)
        {
            if (Int32.TryParse(IntLine, out int IntNumber))
            {
                if (IntNumber >= 1 && IntNumber <= 10)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Точность должна быть от 1 до 10 знаков после запятой.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show($"Неподходящий формат: {IntName}");
                return false;
            }
        }
    }
}
