using System.ComponentModel;

namespace AlgProj
{
    public partial class Form1 : Form
    {

        BindingList<DeliveryPoint> deliveryPoints = new BindingList<DeliveryPoint>();

        public Form1()
        {
            InitializeComponent();
            pointsDataGridView.DataSource = deliveryPoints;
            FormClosing += (s, e) =>
            {
                var result = MessageBox.Show("Czy chcesz zamkn¹æ programs? ", "Zamknij program!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // TODO save data
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            var form = new AddDeliveryPointForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                deliveryPoints.Add(form.DeliveryPoint());
            }
            form.Dispose();
        }

        private void removePointButton_Click(object sender, EventArgs e)
        {
            if (pointsDataGridView.SelectedRows.Count > 0)
            {
                pointsDataGridView.Rows.RemoveAt(pointsDataGridView.SelectedRows[0].Index);
            }
        }

        private void editPointButton_Click(object sender, EventArgs e)
        {
            if (pointsDataGridView.SelectedRows.Count > 0)
            {
                var deliveryPoint = deliveryPoints.ElementAt(pointsDataGridView.SelectedRows[0].Index);
                var form = new AddDeliveryPointForm(deliveryPoint);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var updated = form.DeliveryPoint();
                    deliveryPoint.Name = updated.Name;
                    deliveryPoint.Point = updated.Point;
                    deliveryPoints.ResetItem(pointsDataGridView.SelectedRows[0].Index);
                }
            }
        }
    }
}