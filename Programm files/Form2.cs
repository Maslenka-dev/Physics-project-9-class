namespace Physics_project_9_class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try // Обработка исключения FormatException
            {
                // Переменные номера задачи, вводимого в текстовое поле
                int UniformMotionNumberOfTasks;
                int UniformCircularMotionNumberOfTasks;
                int EquidistantMotionNumberOfTasks;
                int ElectricalResistivityNumberOfTasks;

                //  Блок для создания папок с задачами, если текстовые поля не пустые
                if (!string.IsNullOrEmpty(UniformMotionMaskedTextBox.Text) || !string.IsNullOrEmpty(UniformCircularMotionMaskedTextBox.Text) || !string.IsNullOrEmpty(EquidistantMotionMaskedTextBox.Text) || !string.IsNullOrEmpty(ElectricalResistivityMaskedTextBox.Text))
                {
                    Program.CreateFolderIfNotExists(Program.mainFolder);

                    if (!string.IsNullOrEmpty(UniformMotionMaskedTextBox.Text))
                    {
                        UniformMotionNumberOfTasks = Convert.ToInt32(UniformMotionMaskedTextBox.Text);
                        Program.CreateFolderIfNotExists(UniformMotion.folderOfTasks);
                        UniformMotion task1 = new UniformMotion(UniformMotionNumberOfTasks);
                    }
                    if (!string.IsNullOrEmpty(UniformCircularMotionMaskedTextBox.Text))
                    {
                        UniformCircularMotionNumberOfTasks = Convert.ToInt32(UniformCircularMotionMaskedTextBox.Text);
                        Program.CreateFolderIfNotExists(UniformCircularMotion.folderOfTasks);
                        UniformCircularMotion task2 = new UniformCircularMotion(UniformCircularMotionNumberOfTasks);
                    }
                    if (!string.IsNullOrEmpty(EquidistantMotionMaskedTextBox.Text))
                    {
                        EquidistantMotionNumberOfTasks = Convert.ToInt32(EquidistantMotionMaskedTextBox.Text);
                        Program.CreateFolderIfNotExists(EquidistantMotion.folderOfTasks);
                        EquidistantMotion task3 = new EquidistantMotion(EquidistantMotionNumberOfTasks);
                    }
                    if (!string.IsNullOrEmpty(ElectricalResistivityMaskedTextBox.Text))
                    {
                        ElectricalResistivityNumberOfTasks = Convert.ToInt32(ElectricalResistivityMaskedTextBox.Text);
                        Program.CreateFolderIfNotExists(ElectricalResistivity.folderOfTasks);
                        ElectricalResistivity task4 = new ElectricalResistivity(ElectricalResistivityNumberOfTasks);
                    }
                    MessageBox.Show("Задачи успешно созданы в указанной вами папке!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Введите количество задач!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Возникло исключение FormatException!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Введите корректные значения для задач", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // Выход из приложения
            }
            Application.Exit(); // Выход из приложения
        }
    }
}
