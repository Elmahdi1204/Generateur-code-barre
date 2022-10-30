using IronOcr;
using System;
using System.Windows.Forms;


namespace Generateur_code_barre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ocr = new IronTesseract();
            using(var input = new OcrInput(@"C:\Users\Elmahdi\Desktop\R(1).jfif"))
            {
                var result = ocr.Read(input);
                result.SaveAsTextFile(@"C:\Users\Elmahdi\Desktop\x.txt");

            }
        }
    }
}
