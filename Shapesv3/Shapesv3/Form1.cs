namespace Shapesv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShapeChoiceBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void RequestDimensionValue(string DimensionName, string DimensionName2)
        {
            DimensionLabel1.Text = $"What is the shape's {DimensionName}? ";
            DimensionBox1.Visible = true;
            if (DimensionName2 != "")
            {
                DimensionLabel2.Text = $"What is the shape's {DimensionName2}? ";
                DimensionBox2.Visible = true;
            }
        }
        public static Shape Create(string shapeName)
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
                RequestDimensionValue("Diameter", "");
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
            var mainShape = Create(ShapeChoiceBox.Text);
            if (mainShape is Rectangle || mainShape is Triangle)
            {
                mainShape.BaseWidth = Convert.ToDouble(DimensionBox1.Text);
                mainShape.LenHeightDie = Convert.ToDouble(DimensionBox2.Text);
            }
            else if (mainShape is Circle)
            {
                mainShape.LenHeightDie = Convert.ToDouble(DimensionBox1.Text);
            }
            AreaResultLabel.Text = $"The area is equal to {mainShape.CalculateArea()}";
            PerimResultLabel.Text = $"The perimeter is equal to {mainShape.CalculatePerimeter()}";

        }
    }
}