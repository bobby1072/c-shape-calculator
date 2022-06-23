namespace Shapesv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShapeChoiceBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void RequestDimensionValue(string DimensionName, string? DimensionName2 = null)
        {
            DimensionLabel1.Text = $"What is the shape's {DimensionName}? ";
            DimensionBox1.Visible = true;

            if (!string.IsNullOrWhiteSpace(DimensionName2))
            {
                DimensionLabel2.Text = $"What is the shape's {DimensionName2}? ";
                DimensionBox2.Visible = true;
            }
        }
        public static Shape CreateShape(string shapeName)
        {
            var type = Type.GetType(typeof(Shape).Namespace + "." + shapeName, throwOnError: false);
            return (Shape)Activator.CreateInstance(type);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DimensionLabel2.Text = "";
            DimensionBox2.Visible = false;
            DimensionLabel2.Text = "";
            DimensionBox2.Visible = false;
            AreaResultLabel.Text = "";
            PerimResultLabel.Text = "";

            if (ShapeChoiceBox.Text == "Triangle")
            {
                RequestDimensionValue("base", "height");
                SubmitButton.Visible = true;
            }
            else if (ShapeChoiceBox.Text == "Rectangle")
            {
                RequestDimensionValue("width", "length");
                SubmitButton.Visible = true;
            }
            else if (ShapeChoiceBox.Text == "Circle")
            {
                RequestDimensionValue("Diameter");
                SubmitButton.Visible = true;
            }
        }

        private void DimensionLabel1_Click(object sender, EventArgs e)
        {
        }

        private void DimensionBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            AreaResultLabel.Text = "";
            PerimResultLabel.Text = "";
            var mainShape = CreateShape(ShapeChoiceBox.Text);

            bool isDouble = Double.TryParse(DimensionBox1.Text, out double dimension1);
            bool isDouble2 = Double.TryParse(DimensionBox2.Text, out double dimension2);

            if (isDouble && isDouble2)
            {
                if (mainShape is Rectangle)
                {
                    var rect = (Rectangle) mainShape;
                    rect.SetDimensions(dimension1, dimension2);
                }
                else if (mainShape is Triangle tri)
                {
                    tri.SetDimensions(dimension1, dimension2);
                }
            }
            else if (mainShape is Circle && isDouble)
            {
                mainShape.SetDimensions(dimension1);
            }

            AreaResultLabel.Text = $"The area is equal to {mainShape.CalculateArea()}";
            PerimResultLabel.Text = $"The perimeter is equal to {mainShape.CalculatePerimeter()}";
        }
    }
}