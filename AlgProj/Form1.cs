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
                var result = MessageBox.Show("Czy chcesz zamkn¹æ program? ", "Zamknij program!", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
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
                var deliveryPoint = form.DeliveryPoint();
                deliveryPoints.Add(deliveryPoint);
                DrawGraph();
            }
            form.Dispose();
        }

        private void removePointButton_Click(object sender, EventArgs e)
        {
            if (pointsDataGridView.SelectedRows.Count > 0)
            {
                pointsDataGridView.Rows.RemoveAt(pointsDataGridView.SelectedRows[0].Index);
                DrawGraph();
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
                    DrawGraph();
                }
            }
        }

        private void DrawGraph()
        {
            if (deliveryPoints.Count < 2)
            {
                return;
            }
            var fullGraph = new Graph();
            var nodes = deliveryPoints.Select(x => new Node(x)).ToList();

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (i != j)
                    {
                        fullGraph.AddEdge(new Edge(nodes[i], nodes[j]));
                    }
                }
            }

            var minSpaningTree = fullGraph.Kruskal();
            Helper.DrawGraph(routePictureBox, minSpaningTree);
            routeRichTextBox.Text = string.Join('\n', minSpaningTree.Edges.Select(e => $"z '{e.Start.DeliveryPoint.Name}' do '{e.End.DeliveryPoint.Name}' {e.Weight:F2} m"));
            routeRichTextBox.Text += "\n";
            routeRichTextBox.Text += "--------------------------------\n";
            routeRichTextBox.Text += $"D³ugoœæ ca³ej trasy: {minSpaningTree.Edges.Sum(x => x.Weight):F2} m";
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(routeRichTextBox.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    File.WriteAllText(saveFileDialog.FileName, routeRichTextBox.Text);
                }
            }
        }
    }
}