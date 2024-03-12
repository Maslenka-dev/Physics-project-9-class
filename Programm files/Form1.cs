namespace Physics_project_9_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ���� ��� ������ ���� ��� ����� � ��������
            while (Program.mainFolder == null)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // ���� ����� �������
                {
                    Program.mainFolder = $"{folderBrowserDialog1.SelectedPath}\\������ �� ������";
                }
                else
                {
                    MessageBox.Show("�������� ���� ��� ����� � ��������!", "���������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            Form2 form2 = new Form2(); // �������� ������� ����� Form2
            form2.Show(); // Form2 �����������
            Hide(); // ������� ����� ����������
        }
    }
}
