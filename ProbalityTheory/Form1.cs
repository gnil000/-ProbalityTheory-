using System.Diagnostics;

namespace ProbalityTheory
{
    public partial class Form1 : Form
    {
        int countOfVariant;
        int countOfTask;
        WordCreator wordFile = new WordCreator("SampleTryVS3.dot");
        Dictionary<string, string> items = new Dictionary<string, string> {
                { "<VARIANT>", "5"},
                { "<FIO>", "Бульба Вадим Игоревич"},
                { "<A>", "7"},
                { "<C>", "20"},
                { "<E>", "3"},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void SaveData()
        {
            //Добавляем код для манипуляции с данными
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10);
            //wordFile.Process(items);
        }

        private void CreateFiles_Click(object sender, EventArgs e)
        {
            countOfVariant = (int)NumbersOfVariants.Value;
            Debug.WriteLine($"Прямое значение = {NumbersOfVariants.Value}\tЗначение переменной countOfVariant = {countOfVariant}");

            if (radioButton1.Checked)
               countOfTask = 1;
            if (radioButton2.Checked)
                countOfTask = 2;
            if (radioButton3.Checked)
                countOfTask = 3;

            Debug.WriteLine($"Значение радиокнопки: {countOfTask}");

            
            //var wordFile = new WordCreator("SampleTryVS3.dot");
            /*
            var items = new Dictionary<string, string> {
                { "<VARIANT>", "5"},
                { "<FIO>", "Бульба Вадим Игоревич"},
                { "<A>", "7"},
                { "<C>", "20"},
                { "<E>", "3"},
            };*/

            //wordFile.Process(items);
            using (Wait_Window frm = new Wait_Window(SaveData))
            {
                frm.ShowDialog(this);
            }

            //string path;
            saveFileDialog1.Filter = "|*.doc";
            saveFileDialog1.Title = "Сохраните файл с вариантами";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string path = saveFileDialog1.FileName;
                wordFile.saveDocument(path);
                MessageBox.Show("Файл сохранён");
                //var wordFile = new WordCreator("SampleTryVS3.dot", path);

            }


            //saveFileDialog1.ShowDialog(this);
            //saveFileDialog1.ShowDialog(this);
        }

        private void StudentFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = File.ReadAllText(filename);
                MessageBox.Show("Файл открыт");
            }
        }

       
    }
}