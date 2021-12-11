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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonHesapla.Enabled = false;
        }


        int matrisSatir;
        int matrisSutun;
        int[,] textboxVeriler;
        TextBox[,] textboxArray;       
        Label[,] labelArray;
        string[,] Names;
        Label templbl = new Label();
        TextBox tempTextbox = new TextBox();


        static readonly int MAXN = 100;
        static int INF = (int)1e7;

        static int[,] dis = new int[MAXN, MAXN];  // ana matris
        static int[,] Next = new int[MAXN, MAXN];
       // static int[,] sMatrix = new int[MAXN, MAXN]; // s matrisi

        public void matrisOlusturButton_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();

            try
            {
                matrisSatir = Convert.ToInt32(textBoxSatir.Text);
                matrisSutun = Convert.ToInt32(textBoxSutun.Text);

            }
            catch
            {
                string title = "Uyarı";
                string message = "Matris satır ve sütun alanları boş bırakılamaz.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.OK)
                {
                    textBoxSatir.Clear();
                    textBoxSutun.Clear();
                }

                return;
            }

            if (matrisSatir != matrisSutun)
            {
                MessageBox.Show("Matris satır ve sütun sayıları eşit olmalıdır.", "Uyarı", MessageBoxButtons.OK);
                return;
            }

            Olustur();
        }
        public void Olustur()
        {
            buttonHesapla.Enabled = true;
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

            labelArray = new Label[matrisSatir, matrisSutun];
            textboxArray = new TextBox[matrisSatir, matrisSutun];
            Names = new string[matrisSatir, matrisSutun];
            //int[,] textboxVeriler = new int[matrisSatir, matrisSutun]; // textboxtaki verileri tutmak için dizi

            panel1.Width = matrisSatir * 170;
            panel1.Height = matrisSutun * 100;
            //panel1.BackColor = Color.Blue; ;
            Size = new Size(matrisSatir * 200, matrisSutun * 180);

            for (int a = 0; a < matrisSatir; a++)
            {
                for (int b = 0; b < matrisSutun; b++)
                {
                    Names[a, b] = Convert.ToString(a + 1) + Convert.ToString(b + 1);
                }
            }

            LabelVeTextBoxlariOlustur();
        }

        
        private void LabelVeTextBoxlariOlustur()
        {
            
            Label labelUyari2 = new Label();          
            labelUyari2.Text = "Lütfen Düğümler Arası Mesafeleri Giriniz:"+ "\n" + "( İlgili Mesafe Sonsuz İse 'INF' Yazınız )";
            labelUyari2.Left = 60;
            labelUyari2.Size= new System.Drawing.Size(470, 50);
  
            //labelUyari2.BackColor = Color.Red;
            labelUyari2.Font = new Font("Myanmar Text", 10, FontStyle.Bold);
            panel1.Controls.Add(labelUyari2);

            
            for (int i = 0; i < matrisSatir; i++)
            {
                for (int j = 0; j < matrisSutun; j++)
                {
                    templbl = new Label();
                    templbl.Name = "label" + Names[i, j];
                    templbl.Text = (i + 1) + " ile " + (j + 1);
                    templbl.Top = (i + 1) * 80;
                    templbl.Left = (j + 1) * 80;
                    templbl.Size = new System.Drawing.Size(68, 20);
                    labelArray[i, j] = templbl;

                    tempTextbox = new TextBox();
                    tempTextbox.Name = "textbox" + Names[i, j];
                    tempTextbox.Top = (i * 80) + 100;
                    // tempTextbox.Text = tempTextbox.Name;
                    tempTextbox.Font = new Font("MS Reference Sans Serif", 8, FontStyle.Regular);
                    tempTextbox.Left = (j + 1) * 80;
                    tempTextbox.Margin = new Padding(3, 3, 3, 3);
                    tempTextbox.Size = new System.Drawing.Size(48, 26);
                    textboxArray[i, j] = tempTextbox;

                }
            }

            
            if(matrisSatir==3 && matrisSutun == 3)
            {
                textboxArray[0, 0].Text = "0";
                textboxArray[0, 1].Text = "8";
                textboxArray[0, 2].Text = "5";
                textboxArray[1, 0].Text = "2";
                textboxArray[1, 1].Text = "0";
                textboxArray[1, 2].Text = "INF";
                textboxArray[2, 0].Text = "INF";
                textboxArray[2, 1].Text = "1";
                textboxArray[2, 2].Text = "0";
            }

            if (matrisSatir == 4 && matrisSutun == 4)
            {
                textboxArray[0, 0].Text = "0";
                textboxArray[0, 1].Text = "3";
                textboxArray[0, 2].Text = "INF";
                textboxArray[0, 3].Text = "7";

                textboxArray[1, 0].Text = "8";
                textboxArray[1, 1].Text = "0";
                textboxArray[1, 2].Text = "2";
                textboxArray[1, 3].Text = "INF";

                textboxArray[2, 0].Text = "5";
                textboxArray[2, 1].Text = "INF";
                textboxArray[2, 2].Text = "0";
                textboxArray[2, 3].Text = "1";

                textboxArray[3, 0].Text = "2";
                textboxArray[3, 1].Text = "INF";
                textboxArray[3, 2].Text = "INF";
                textboxArray[3, 3].Text = "0";

            }


            foreach (var item in labelArray)
            {
                panel1.Controls.Add(item);
            }

            foreach (var item in textboxArray)
            {
                panel1.Controls.Add(item);
                //form2.panel1Form2.Controls.Add(item);
                             
            }
          

        }


        public int[,] TextBoxVerileriOku()
        {
            
            textboxVeriler = new int[matrisSatir, matrisSutun]; // textboxtaki verileri tutmak için dizi
            for (int i = 0; i < matrisSatir; i++)
            {
                for (int j = 0; j < matrisSutun; j++)
                {
                    if(textboxArray[i, j].Text=="INF")
                    {
                        textboxVeriler[i, j] = INF;
                    }                
                    else
                    {
                        textboxVeriler[i, j] = Convert.ToInt32(textboxArray[i, j].Text);
                    }

                }
            }
            return textboxVeriler;
        }

        static void initialise(int V, int[,] graph)
        {
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    dis[i, j] = graph[i, j];

                    // Düğümler arasında kenar yoksa
                    // i ve j
                    if (graph[i, j] == INF)
                        Next[i, j] = -1;
                    else
                        Next[i, j] = j;
                }
            }
        }
        static List<int> constructPath(int u, int v)
        {
          
            if (Next[u, v] == -1)
                return null;

            // En kısa yolu vektöre saklıyoruz.
            List<int> path = new List<int>();
            path.Add(u);

            while (u != v)
            {
                u = Next[u, v];
                path.Add(u);
            }
            return path;
        }

        
        static void floydWarshall(int V)
        {
            for (int k = 0; k < V; k++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {

                        
                        if (dis[i, k] == INF ||
                            dis[k, j] == INF)
                            continue;

                        if (dis[i, j] > dis[i, k] +
                                        dis[k, j])
                        {
                            dis[i, j] = dis[i, k] +
                                        dis[k, j];
                            Next[i, j] = Next[i, k];
                        }
                    }
                }
            }
        }

        // En kısa yolu yazdırma
        static void printPath(List<int> path)
        {
            int n = path.Count;

            for (int i = 0; i < n - 1; i++)
                Console.Write(path[i]+1 + " -> ");

            Console.Write(path[n - 1]+1 + "\n");
        }

        static String convertPath(List<int> path)
        {
            int n = path.Count;
            String tmp="";
            for (int i = 0; i < n - 1; i++)
            {
                tmp = tmp.Insert(tmp.Length, String.Join("", path[i] + 1));
                tmp = tmp.Insert(tmp.Length, String.Join("", " -> "));
            }
            tmp =tmp.Insert(tmp.Length, String.Join("", path[n - 1] + 1));
            return tmp;
        }

        // Düğümler arasındaki en kısa yolları yazdırma
        static void printSolution(int V)
        {
            Console.WriteLine("Aşağıdaki matris düğümler arasındaki en kısa mesafe yollarını bulmaktadır.");
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (dis[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(dis[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
        
        // sadece sayı girişi
      private void textBoxSatir_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

      private void textBoxSutun_KeyPress(object sender, KeyPressEventArgs e)
      {
         e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
      }

       
  
        public void buttonHesapla_Click(object sender, EventArgs e)
     
        {
            
            int[,] graph = TextBoxVerileriOku();           
            initialise(matrisSatir, graph);
            //FloydWarshall( matrisSatir);

            floydWarshall(matrisSatir);
            printSolution(matrisSatir);

            var floydMatrisForm = new FloydMatrisForm(dis, matrisSatir, matrisSutun);

            List<int> path;
            for (int i = 0; i < matrisSatir; i++)
            {
                for (int j = 0; j < matrisSatir; j++)
                {

                    Console.Write((i + 1) + " ile " + (j + 1) + " arasındaki en kısa yol: ");
                    path = constructPath(i, j);
                    String tmp = convertPath(path);
                    if (path.Count == 1)
                    {
                        Console.WriteLine("---");
                        floydMatrisForm.listBox1.Items.Add((i + 1) + " ile " + (j + 1) + " arasındaki en kısa yol: " + "---");                        
                        
                        //label1.Text="(i + 1) + " ile " + (j + 1) + " arasındaki en kısa yol: + --- ";
                    }
                    else
                    {
                        printPath(path);
                        Console.WriteLine("test  " + tmp);
                        floydMatrisForm.listBox1.Items.Add((i + 1) + " ile " + (j + 1) + " arasındaki en kısa yol: " + tmp);
                        //label1.Text="(i + 1) + " ile " + (j + 1) + " arasındaki en kısa yol: + tmp ";
                    }

                }
            }

            floydMatrisForm.Show();

        }



    }

}
