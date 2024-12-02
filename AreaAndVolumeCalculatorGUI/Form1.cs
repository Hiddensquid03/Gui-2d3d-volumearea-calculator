namespace AreaAndVolumeCalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "2D")
            {
                comboBox2.Text = string.Empty;
                comboBox2.Visible = true;
                comboBox2.Items.AddRange(new string[3]
                {
                    "Triangle", "Elipse", "Rectangle "
                });
                textBox3.Visible = false;
            }

            else if (comboBox1.Text == "3D")
            {
                comboBox2.Text = string.Empty;
                comboBox2.Visible = true;
                comboBox2.Items.AddRange(new string[3]
                {
                    "Triangular Prism", "Ellipsoid", "Cuboid"
                });
                textBox3.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                comboBox1.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label1.Text = "answer: ?";
            if (comboBox1.Text == "2D" || comboBox1.Text == "3D")
            {
                double length, width;
                if (!double.TryParse(textBox1.Text, out length))
                    return;

                if (!double.TryParse(textBox2.Text, out width))
                    return;
                if (comboBox1.Text == "2D")
                {
                    CalcArea? shape = null;
                    if (comboBox2.Text == "Triangle")
                    {
                        shape = new Triangle(length, width);
                    }
                    else if (comboBox2.Text == "Elipse")
                    {
                        shape = new Elipse(length, width);
                    }
                    else if (comboBox2.Text == "Rectangle")
                    {
                        shape = new Rectangle(length, width);
                    }
                    if (shape != null)
                    {
                        label1.Text = "answer: " + shape.Area();
                    }
                }
                else if (comboBox1.Text == "3D")
                {
                    double depth;
                    if (!double.TryParse(textBox3.Text, out depth))
                        return;
                    CalcVolume? shape = null;
                    if (comboBox2.Text == "Ellipsoid")
                    {
                        shape = new Ellipsoid( depth,length, width);
                    }
                    else if (comboBox2.Text == "Triangular Prism")
                    {
                        shape = new TriangularPrism (depth,length, width);
                    }
                    else if (comboBox2.Text == "Cuboid")
                    {
                        shape = new Cuboid(depth, length, width);
                    }
                    if (shape != null)
                    {
                        label1.Text = "answer: " + shape.Volume();
                    }
                }
            } 
        }
    }
}

//sphere cuboid triangular prism