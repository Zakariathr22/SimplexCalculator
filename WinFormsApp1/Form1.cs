using System.Drawing;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int Variables = 0, Constraints = 0;
        public List<TextBox> textBoxList = new List<TextBox>();
        public List<List<TextBox>> textBoxList2 = new List<List<TextBox>>();
        public List<ComboBox> EquationDirections = new List<ComboBox>();
        public List<TextBox> RightValues = new List<TextBox>();

        static public bool isMax = true;
        static public List<double> ProblemVar = new List<double>();
        static public List<List<double>> ProblemCons = new List<List<double>>();
        static public List<string> ProblemDirection = new List<string>();
        static public List<double> RightVal = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Var_Num_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ZeroEquationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cons_Num_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxList.Count; i++)
            {
                ProblemVar.Add(double.Parse(textBoxList[i].Text));
            }

            if (MAXorMIN.Text == "MAX") isMax = true;
            else isMax = false;

            for (int i = 0; i< textBoxList2.Count; i++)
            {
                ProblemCons.Add(new List<double>());
                for (int j=0; j< textBoxList2[i].Count; j++)
                {
                    ProblemCons[i].Add(double.Parse(textBoxList2[i][j].Text));
                }
            }

            for (int i = 0; i< EquationDirections.Count; i++)
            {
                ProblemDirection.Add(EquationDirections[i].Text);
            }

            for (int i = 0; i< RightValues.Count; i++)
            {
                RightVal.Add(double.Parse(RightValues[i].Text));
            }

            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            textBoxList.Clear();
            textBoxList2.Clear();
            EquationDirections.Clear();
            RightValues.Clear();

            ZeroEquationPanel.Controls.Clear();
            EquationsPanel.Controls.Clear();

            ZeroEquationPanel.Visible = false;
            EquationsPanel.Visible = false;
            Z_X.Visible = false;
            MAXorMIN.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            textBoxList.Clear();
            textBoxList2.Clear();
            EquationDirections.Clear();
            RightValues.Clear();

            Z_X.Visible = true;
            MAXorMIN.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            Variables = (int)Var_Num.Value;
            Constraints = (int)Cons_Num.Value;
            if (MAXorMIN.Text == "MAX") isMax = true;
            else isMax = false;

            
            ZeroEquationPanel.Controls.Clear();
            ZeroEquationPanel.Visible = true;
            ZeroEquationPanel.AutoScrollMinSize = new System.Drawing.Size(120*Variables, 0);
            
            EquationsPanel.Controls.Clear();
            EquationsPanel.Visible = true;
            EquationsPanel.AutoScroll = true;
            EquationsPanel.AutoScrollMinSize = new System.Drawing.Size(120 * Variables + 115, 0);

            for (int i=0; i<Variables; i++)
            {
                textBoxList.Add(new TextBox
                {
                    Font = new Font("Segoe UI", 12),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.Snow,
                    Width = 60
                }) ;
                ZeroEquationPanel.Controls.Add(textBoxList[i]) ;
                if (i != Variables - 1)
                    ZeroEquationPanel.Controls.Add(new Label
                    {
                        Text = "X" + (i + 1) + " + ",
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        Width = 45
                    });
                else
                    ZeroEquationPanel.Controls.Add(new Label
                    {
                        Text = "X" + (i + 1),
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        Width = 30
                    }) ;
            }

            for (int i=0;i<Constraints; i++)
            {
                textBoxList2.Add(new List<TextBox>());

                for (int j=0; j < Variables; j++)
                {
                    textBoxList2[i].Add(new TextBox
                    {
                        Font = new Font("Segoe UI", 12),
                        TextAlign = HorizontalAlignment.Center,
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor = Color.Snow,
                        Width = 60
                    });
                    EquationsPanel.Controls.Add(textBoxList2[i][j]);
                    if (j != Variables - 1)
                        EquationsPanel.Controls.Add(new Label
                        {
                            Text = "X" + (j + 1) + " + ",
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            Width = 45
                        });
                    else
                        EquationsPanel.Controls.Add(new Label
                        {
                            Text = "X" + (j + 1),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            Width = 30
                        });
                }

                EquationDirections.Add(new ComboBox
                {
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Width = 45,
                    Text = "≤",
                    BackColor = Color.Snow
                }) ;
                EquationDirections[i].Items.Add("≤");
                EquationDirections[i].Items.Add("≥");
                EquationDirections[i].Items.Add("=");
                EquationsPanel.Controls.Add((ComboBox)EquationDirections[i]);

                RightValues.Add(new TextBox
                {
                    Font = new Font("Segoe UI", 12),
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.Snow,
                    Width = 60
                }) ;
                EquationsPanel.Controls.Add(RightValues[i]);

                Panel NewLine = new Panel
                {
                    Height = 0,
                    Width = 0,
                    Dock = DockStyle.Bottom,
                    Margin = new Padding(0),
                };
                EquationsPanel.SetFlowBreak(NewLine, true);
                EquationsPanel.Controls.Add(NewLine);
            }
        }
    }
}