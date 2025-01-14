namespace AlgProj
{
    public partial class AddDeliveryPointForm : Form
    {
        public AddDeliveryPointForm(DeliveryPoint? deliveryPoint = null)
        {
            InitializeComponent();
            if (deliveryPoint != null )
            {
                nameTextBox.Text = deliveryPoint.Name;
                xTextBox.Text = deliveryPoint.Point.X.ToString();
                yTextBox.Text = deliveryPoint.Point.Y.ToString();
                Paint += new PaintEventHandler((s, e) => DrawPoint((int)deliveryPoint.Point.X, (int)deliveryPoint.Point.Y));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs mouseEvent)
            {
                xTextBox.Text = mouseEvent.X.ToString();
                yTextBox.Text = mouseEvent.Y.ToString();
                DrawPoint(mouseEvent.X, mouseEvent.Y); 
            }
        }

        private void DrawPoint(int x, int y)
        {
            Helper.DrawPoint(mapPictureBox, x, y);
        }

        private bool IsFormValid()
        {
            nameLabelError.Text = string.Empty;
            pointLabelError.Text = string.Empty;

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameLabelError.Text = "Nazwa jest pusta";
                return false;
            }

            if (string.IsNullOrEmpty(xTextBox.Text) || string.IsNullOrEmpty(yTextBox.Text))
            {
                pointLabelError.Text = "Wybierz punkt na mapie";
                return false;
            }

            return true;
        }

        public DeliveryPoint DeliveryPoint()
        {
            return new DeliveryPoint()
            {
                Name = nameTextBox.Text,
                Point = new Point()
                {
                    X = xTextBox.IntValue(),
                    Y = yTextBox.IntValue()
                }
            };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
