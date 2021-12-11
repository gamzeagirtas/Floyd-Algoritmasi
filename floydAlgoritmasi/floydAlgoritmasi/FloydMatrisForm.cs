using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floydAlgoritmasi
{
    public partial class FloydMatrisForm : Form
    {
        TextBox[,] textBoxArray = new TextBox[100,100];

        int[,] _matris;
        int _satirSayisi;
        int _sutunSayisi;
        
        public FloydMatrisForm(int[,] matris, int satirSayisi, int sutunSayisi)
        {
            _matris = matris;
            _satirSayisi = satirSayisi;
            _sutunSayisi = sutunSayisi;

            InitializeComponent();

            TextBoxlariOlustur();
        }


        private void TextBoxlariOlustur()
        {
            matrisTextBoxPanel.Width = _satirSayisi * 140;
            matrisTextBoxPanel.Height = _sutunSayisi * 100;
            //matrisTextBoxPanel.BackColor = Color.Red;

            Label labelUyari1 = new Label();
            labelUyari1.Text = "*** D MATRİSİ ***";
            labelUyari1.Size = new System.Drawing.Size(379, 22);
            labelUyari1.BackColor = Color.PeachPuff;
            labelUyari1.Font = new Font("MV Boli", 9, FontStyle.Bold);
            labelUyari1.Left = 50;
            matrisTextBoxPanel.Controls.Add(labelUyari1);

            for (int i = 0; i < _satirSayisi; i++)
            {
                for (int j = 0; j < _sutunSayisi; j++)
                {
                    
                    var textBox = new TextBox();
                    textBox.Enabled = false;
                    textBox.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);                  
                    textBox.Top = (i+1) * 60;
                    textBox.Left = (j + 1) * 80 - 80;
                    textBox.Margin = new Padding(3, 3, 3, 3);
                    textBox.Size = new System.Drawing.Size(48, 26);
                    textBox.Text = _matris[i, j].ToString();
                    textBoxArray[i, j] = textBox;
                    matrisTextBoxPanel.Controls.Add(textBox);
                    
                }
            }

            

            // ayarlanıcak
            labelSMatris.Location = new Point(labelSMatris.Location.X + 50, 40);
            listBox1.Location = new Point(listBox1.Location.X + 50,80);
            Size = new Size(_satirSayisi * 250, _sutunSayisi * 150);

            

        }

        private void FloydMatrisForm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
        }
    }
}
