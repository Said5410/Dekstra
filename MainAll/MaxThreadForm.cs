using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainAll
{
    public partial class MaxThreadForm : Form
    {
        public Graphics g;
        Bitmap b;
        int d = 20;
        static int countNodes = 0;
        List<point> p = new List<point>();
        bool mbPress = false;
        bool mbPress2 = false;
        static public int[,] a = new int[countNodes, countNodes];
        public int[,] c = new int[countNodes, countNodes];
        static int[,] f;
        bool DrawLining;
        const int INFINITY = int.MaxValue / 2;
        Random r = new Random();

        public MaxThreadForm()
        {
            InitializeComponent();
        }
        public class point
        {
            public float x, y;
            public int z = 0;
        }
        public void Draw()
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);


            if (p != null)
            {


                for (int i = 0; i < p.Count; i++)
                {
                    if (p[i].x > pictureBox1.Width - d)
                    {
                        p[i].x = pictureBox1.Width - d;
                    }
                    if (p[i].y > pictureBox1.Height - d)
                    {
                        p[i].y = pictureBox1.Height - d;
                    }

                    if (p[i].x < d / 2)
                    {
                        p[i].x = d / 2;
                    }
                    if (p[i].y < d / 2)
                    {
                        p[i].y = d / 2;
                    }
                }
            }



            if (p != null)
            {


                for (int i = 0; i < p.Count; i++)
                {
                    stolknovenie(p[i].x, p[i].y);
                    if (p[i].x > pictureBox1.Width)
                    {
                        p[i].x = pictureBox1.Width - d;
                    }
                    if (p[i].y > pictureBox1.Height)
                    {
                        p[i].y = pictureBox1.Height - d;
                    }

                    if (p[i].x < 0)
                    {
                        p[i].x = d / 2;
                    }
                    if (p[i].y < 0)
                    {
                        p[i].y = d / 2;
                    }
                    g.DrawEllipse(new Pen(Color.Green), p[i].x - d / 2, p[i].y - d / 2, d, d);
                    g.FillEllipse(new SolidBrush(Color.Wheat), p[i].x - d / 2, p[i].y - d / 2, d, d);
                    //g.DrawString(p[i].z.ToString(), new Font(FontFamily.GenericMonospace, 10.0f), new SolidBrush(Color.Blue), new PointF(p[i].x - 7.5f, p[i].y - 7.5f));

                    Application.DoEvents();

                }
            }
            if (l != null)
            {
                Pen pen = new Pen(Color.Red, 1) { CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 10) };
                g.DrawLine(pen, l.x2, l.y2, l.x1, l.y1);
                DrawLining = true;
            }
            if (a != null)
            {


                for (int i = 0; i < countNodes; i++)
                {
                    for (int j = 0; j < countNodes; j++)
                    {
                        if (a.Length != 0)
                        {

                            if (a[i, j] != 0 && j < p.Count && i < p.Count)
                            {
                                //Console.Write(a[i, j] + " ");
                                Pen pen = new Pen(Color.Red, 1) { CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 10) };
                                g.DrawLine(pen, p[i].x, p[i].y, p[j].x, p[j].y);
                                var cx = (p[i].x + p[j].x) / 2;
                                var cy = (p[i].y + p[j].y) / 2;
                                g.DrawString(a[i, j].ToString(), new Font(FontFamily.GenericMonospace, 10.0f), new SolidBrush(Color.Blue), new PointF(cx - 5, cy - 5));

                            }
                            else
                            {
                                a[i, j] = 0;
                                //Console.Write(a[i, j] + " ");
                            }
                        }
                    }
                }
            }
            if (p != null)
            {
                for (int i = 0; i < p.Count; i++)
                {
                    g.DrawString(p[i].z.ToString(), new Font(FontFamily.GenericMonospace, 10.0f), new SolidBrush(Color.Blue), new PointF(p[i].x - 7.5f, p[i].y - 7.5f));
                }
            }
            pictureBox1.Image = b;
        }

        class Line
        {
            public float x1, y1, x2, y2;
        }
        Line l = null;


        bool t;
        public bool stolknovenie(float x, float y)
        {
            t = true;
            for (int i = 0; i < p.Count; i++)
            {
                if (Math.Sqrt(Math.Pow(x - p[i].x, 2) + Math.Pow(y - p[i].y, 2)) < d)
                {
                    t = false;
                    break;
                }
            }
            return t;
        }

        public void Point(float x, float y)
        {
            DrawLining = false;

            stolknovenie(x, y);
            if (t == true)
            {
                point u = new point();
                u.x = x;
                u.y = y;

                u.z = countNodes++;
                p.Add(u);
            }
            node1Comp.Maximum = countNodes - 1;
            node2Comp.Maximum = countNodes - 1;
            c = a;
            a = new int[countNodes, countNodes];
            for (int i = 0; i < countNodes; i++)
            {
                for (int j = 0; j < countNodes; j++)
                {

                    if (countNodes != 1 && c.GetLength(0) > j && c.GetLength(0) > i)
                    {
                        a[i, j] = c[i, j];
                    }
                }
            }
            Draw();

        }

        int cur = -1;
        int cur2 = -1;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point(e.X, e.Y);
            }
            for (int i = 0; i < p.Count; i++)
            {
                if (Math.Sqrt(Math.Pow(e.X - p[i].x, 2) + Math.Pow(e.Y - p[i].y, 2)) < d / 2 && e.Button == System.Windows.Forms.MouseButtons.Right && DrawLining == false)
                {
                    //DeletePoint(e.X, e.Y);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mbPress = true;
            mbPress2 = true;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                for (int i = 0; i < p.Count; i++)
                {
                    if (Math.Sqrt(Math.Pow(e.X - p[i].x, 2) + Math.Pow(e.Y - p[i].y, 2)) < d / 2)
                    {
                        cur2 = i;
                        l = new Line();
                        break;
                    }
                }

            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left == true)
            {

                for (int i = 0; i < p.Count; i++)
                {
                    if (Math.Sqrt(Math.Pow(e.X - p[i].x, 2) + Math.Pow(e.Y - p[i].y, 2)) < d / 2)
                    {
                        cur = i;
                        dx = e.X - p[i].x;
                        dy = e.Y - p[i].y;
                        break;
                    }
                }

                Draw();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cur != -1 && mbPress)
            {
                bool g = true;
                for (int i = 0; i < p.Count; i++)
                {
                    if (Math.Sqrt(Math.Pow(e.X - dx - p[i].x, 2) + Math.Pow(e.Y - dy - p[i].y, 2)) <= d && i != cur)
                    {

                        g = false;
                        break;
                    }
                }
                if (g)
                {
                    //g.DrawString(a[i, j].ToString(), new Font(FontFamily.GenericMonospace, 10.0f), new SolidBrush(Color.Blue), new PointF(cx - 5, cy - 5));
                    //int distance = (int)Math.Sqrt(Math.Pow(p[cur2].x - p[cur].x, 2) + Math.Pow(p[cur2].y - p[cur].y, 2));
                    //a[cur, cur2] = distance;
                    p[cur].x = e.X - dx;
                    p[cur].y = e.Y - dy;

                    for (int i = 0; i < countNodes; i++)
                    {
                        if (a[cur, i] != 0 && p[cur].x < pictureBox1.Width && p[cur].y < pictureBox1.Height && p[cur].x > 0 && p[cur].y > 0)
                        {
                            int distance = (int)Math.Sqrt(Math.Pow(p[cur].x - p[i].x, 2) + Math.Pow(p[cur].y - p[i].y, 2));
                            //a[cur, i] = distance / 5;
                        }
                    }

                }
            }

            if (cur2 != -1 && mbPress2 && l != null)
            {
                l.x1 = e.X;
                l.y1 = e.Y;
                l.x2 = p[cur2].x;
                l.y2 = p[cur2].y;

            }

            Draw();


        }

        float dx = 0;
        float dy = 0;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cur = -1;

            mbPress = false;
            mbPress2 = false;
            l = null;

            for (int i = 0; i < p.Count; i++)
            {
                if (Math.Sqrt(Math.Pow(e.X - p[i].x, 2) + Math.Pow(e.Y - p[i].y, 2)) <= d && i != cur2 && DrawLining == true)
                {
                    DrawLining = false;
                    int distance = (int)Math.Sqrt(Math.Pow(p[cur2].x - p[i].x, 2) + Math.Pow(p[cur2].y - p[i].y, 2));
                    a[cur2, i] = distance / 5;
                    a[i, cur2] = 0;
                }
            }
            DrawLining = false;
            Draw();
            cur2 = -1;
        }





        static int FindPath(int source, int target)
        {
            int[] Flow = new int[countNodes];
            int[] Link = new int[countNodes];
            int[] Queue = new int[countNodes];
            int QP = 0, QC = 1;

            Queue[0] = source;
            Link[target] = -1;
            int CurVertex;
            Flow[source] = INFINITY;
            while (Link[target] == -1 && QP < QC)
            {
                CurVertex = Queue[QP];
                for (int i = 0; i < countNodes; i++)
                {
                    if ((a[CurVertex, i] - f[CurVertex, i]) > 0 && Flow[i] == 0)
                    {
                        Queue[QC] = i; QC++;
                        Link[i] = CurVertex;
                        if (a[CurVertex, i] - f[CurVertex, i] < Flow[CurVertex])
                        {
                            Flow[i] = a[CurVertex, i];
                        }
                        else
                        {
                            Flow[i] = Flow[CurVertex];
                        }
                    }
                }
                QP++;
            }

            if (Link[target] == -1)
            {
                return 0;
            }

            CurVertex = target;
            while (CurVertex != source)
            {
                f[Link[CurVertex], CurVertex] += Flow[target];
                CurVertex = Link[CurVertex];
            }
            return Flow[target];
        }

        static int MaxFlow(int source, int target)
        {
            f = new int[countNodes, countNodes];

            int MaxFlow = 0;
            int AddFlow;
            do
            {
                AddFlow = FindPath(source, target);
                MaxFlow += AddFlow;
            } while (AddFlow > 0);
            return MaxFlow;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int source = int.Parse(node1Comp.Value.ToString());
            int target = int.Parse(node2Comp.Value.ToString());
            resultLabel.Text = "Максимальный поток: " + MaxFlow(source, target);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            a = new int[0, 0];
            countNodes = 0;
            p = new List<point>();
            g.Clear(Color.Empty);
            pictureBox1.Image = b;

            node1Comp.Value = 0;
            node2Comp.Value = 0;
        }

        private void MaxThreadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            a = new int[0, 0];
            countNodes = 0;
            p = new List<point>();
            g.Clear(Color.Empty);
            pictureBox1.Image = b;

            node1Comp.Value = 0;
            node2Comp.Value = 0;
        }

        private void openBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openGraph = new OpenFileDialog();
            openGraph.Filter = "graph files (*.fgrf) | *.fgrf";

            openGraph.ShowDialog();

            //Очистка поля
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            a = new int[0, 0];
            countNodes = 0;
            p = new List<point>();
            g.Clear(Color.Empty);
            pictureBox1.Image = b;

            var path = openGraph.FileName;
            try
            {
                StreamReader sr = File.OpenText(path);
                sr.ReadLine();
                countNodes = int.Parse(sr.ReadLine());

                a = new int[countNodes, countNodes];
                string line;
                int counter = 0;
                while ((line = sr.ReadLine()) != "Массив координат")
                {
                    string[] fields = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < fields.Length; i++)
                    {
                        a[counter, i] = int.Parse(fields[i]);
                    }
                    counter++;
                }
                counter = 0;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] fields = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    point u = new point();
                    u.x = int.Parse(fields[0]);
                    u.y = int.Parse(fields[1]);

                    u.z = int.Parse(fields[2]);
                    p.Add(u);

                }
                sr.Close();
                Draw();
            }
            catch { }
        }



        private void saveBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveGraph = new SaveFileDialog();
            saveGraph.Filter = "graph files (*.fgrf) | *.fgrf";

            saveGraph.ShowDialog();

            var path = saveGraph.FileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {

                    sw.WriteLine("Массив Ребер");
                    sw.WriteLine(countNodes);
                    for (int i = 0; i < countNodes; i++)
                    {
                        for (int j = 0; j < countNodes; j++)
                        {
                            sw.Write(a[i, j] + "|");
                        }
                        sw.WriteLine();

                    }
                    sw.WriteLine("Массив координат");

                    for (int i = 0; i < p.Count; i++)
                    {
                        sw.Write(String.Format("{0}|{1}|{2}", p[i].x, p[i].y, p[i].z));
                        sw.WriteLine();
                    }
                }
            }
            catch { }
        }
    }
}
