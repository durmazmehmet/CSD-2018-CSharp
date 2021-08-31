using System;
using System.Windows.Forms;
using System.Drawing;

namespace CSD
{
    class App
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }

    class MainForm : Form
    {
        private Label m_labelName;
        private TextBox m_textBoxName;
        private Button m_buttonOk;
        private Button m_buttonCancel;
        private ListBox m_listBoxCities;
        private ListBox m_listBoxVillages;
        private PictureBox m_pictureBoxCity;
        private Label m_labelLocation;
        
        public MainForm()
        {
            Text = "Sample Window";
            Size = new Size(800, 380);
            Click += MainForm_Click;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;

            m_labelName = new Label();
            m_labelName.Parent = this;
            m_labelName.Location = new Point(20, 3);
            m_labelName.Size = new Size(70, 15);
            m_labelName.Text = "Şehir Adı";
            
            m_textBoxName = new TextBox();
            m_textBoxName.Parent = this;
            m_textBoxName.Location = new Point(20, 20);
            m_textBoxName.Size = new Size(250, 20);
            m_textBoxName.ForeColor = Color.Red;
            m_textBoxName.Font = new Font("Arial", 10);
            m_textBoxName.BackColor = Color.Yellow;
          
            m_buttonOk = new Button();
            m_buttonOk.Text = "Ok";
            m_buttonOk.Parent = this;
            m_buttonOk.Location = new Point(20, 50);
            m_buttonOk.Click += new EventHandler(buttonOkClickHandler);

            m_buttonCancel = new Button();
            m_buttonCancel.Text = "Quit";
            m_buttonCancel.Parent = this;
            m_buttonCancel.Location = new Point(100, 50);
            m_buttonCancel.Click += new EventHandler(buttonCancelClickHandler);

            m_listBoxCities = new ListBox();
            m_listBoxCities.Parent = this;
            m_listBoxCities.Location = new Point(300, 20);
            m_listBoxCities.Size = new Size(200, 300);
            m_listBoxCities.ForeColor = Color.Blue;
            m_listBoxCities.Font = new Font("Arial", 10);
            m_listBoxCities.DoubleClick += M_listBoxCities_DoubleClick;
            m_listBoxCities.SelectedIndexChanged += M_listBoxCities_SelectedIndexChanged;

            m_listBoxVillages = new ListBox();
            m_listBoxVillages.Parent = this;
            m_listBoxVillages.Location = new Point(530, 20);
            m_listBoxVillages.Size = new Size(200, 300);
            m_listBoxVillages.ForeColor = Color.Magenta;
            m_listBoxVillages.Font = new Font("Arial", 10);

            m_listBoxCities.Items.Add("Ankara");
            m_listBoxCities.Items.Add("Eskişehir");
            m_listBoxCities.Items.Add("İzmir");
            m_listBoxCities.Items.Add("Bolu");
            m_listBoxCities.Items.Add("Diyarbakır");
            m_listBoxCities.Items.Add("Trabzon");
            m_listBoxCities.Items.Add("Kars");
            
            m_pictureBoxCity = new PictureBox();
            m_pictureBoxCity.Parent = this;
            m_pictureBoxCity.Location = new Point(20, 80);
            m_pictureBoxCity.Size = new Size(250, 200);
            m_pictureBoxCity.SizeMode = PictureBoxSizeMode.CenterImage;

            m_labelLocation = new Label();
            m_labelLocation.Parent = this;
            m_labelLocation.Location = new Point(20, 285);
        }

        private void M_listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_listBoxVillages.Items.Clear();

            switch (m_listBoxCities.SelectedItem.ToString())
            {
                case "Eskişehir":
                    m_pictureBoxCity.ImageLocation = @"..\..\Eskisehir.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Mihalıççık", "Çifteler", "Odunpazarı", "Seyitgazi", "Alpu" });
                    m_labelLocation.Text = "Adalar";
                    break;
                case "Ankara":
                    m_pictureBoxCity.ImageLocation = @"..\..\Ankara.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Çankaya", "Polatlı", "Sincan", "Kızılcahamam", "Kazan" });
                    m_labelLocation.Text = "Anıttepe";
                    break;
                case "Bolu":
                    m_pictureBoxCity.ImageLocation = @"..\..\Bolu.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Mengen", "Gerede", "Mudurnu", "Göynük", "Dörtdivan" });
                    m_labelLocation.Text = "";
                    break;
                case "İzmir":
                    m_pictureBoxCity.ImageLocation = @"..\..\Izmir.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Alsancak", "Karşıyaka", "Çeşme", "Efes", "Göztepe" });
                    m_labelLocation.Text = "";
                    break;
                case "Trabzon":
                    m_pictureBoxCity.ImageLocation = @"..\..\Trabzon.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Of", "Maçka", "Tonya", "Sürmene", "Vakfıkebir" });
                    m_labelLocation.Text = "";
                    break;
                case "Kars":
                    m_pictureBoxCity.ImageLocation = @"..\..\Kars.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Kağızman", "Sarıkamış", "Selim", "Digor", "Arpaçay" });
                    m_labelLocation.Text = "";
                    break;
                case "Diyarbakır":
                    m_pictureBoxCity.ImageLocation = @"..\..\Diyarbakir.jpg";
                    m_listBoxVillages.Items.AddRange(new string[] { "Sur", "Bağlar", "Ergani", "Bismil", "Silvan" });
                    m_labelLocation.Text = "";
                    break;
            }
        }

        private void M_listBoxCities_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(m_listBoxCities.SelectedItem.ToString());
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Main Window clicked");
        }

        private void buttonOkClickHandler(object o, EventArgs e)
        {
            if (m_textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Arama için bir şehir giriniz");
                m_textBoxName.Focus();
                return;
            }
            int index = m_listBoxCities.Items.IndexOf(m_textBoxName.Text.Trim());
            if (index == -1)
            {
                MessageBox.Show("Böyle bir şehir yok!");
                return;
            }
            m_listBoxCities.SelectedIndex = index;
        }

        private void buttonCancelClickHandler(object o, EventArgs e)
        {
            Close();
        }
    }
}
