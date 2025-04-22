using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Sesli_Komut_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                button1.Text = "Konuş";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                button1.Text = res.Text;
            }
            catch (Exception)
            {
                button1.Text="Hata";
            }

            //Şimdi bu mic tarafından sesleri alıyor ve yazıya dönüştürüyor pc sistemi ing 
            //olmadığı için çalışmıyor ve bunu çalıştırabilmek için extra programı yönetici olarak
            //çalıştırmamız gerekiyor.
        }
    }
}
