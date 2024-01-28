namespace DS_FormImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNAmes = System.IO.Directory.GetFiles(dialog.SelectedPath, "*.jpg");
                foreach (var item in fileNAmes)
                {
                    comboBox1.Items.Add(item);
                }

            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(comboBox1.Text);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}