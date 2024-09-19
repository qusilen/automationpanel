
//  (👉ﾟヮﾟ)👉  👈(⌒▽⌒)👉  👈(ﾟヮﾟ👈)  \\
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using S7.Net;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace lastpanel
{
    public partial class Form1 : Form
    {
        Plc plc1;
        public SqlConnection sqlConnection;
        string connectionString = "Data Source=ESRA\\MSSQLSERVER01;Initial Catalog=receteler;Integrated Security=True;";



        public Form1()
        {
            InitializeComponent();

            /*
            plc1 = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
            plc1.Open();
            if (plc1.IsConnected)
            {
                connectionLabel.Text = "Bağlandı.";
                connectionLabel.ForeColor = Color.Green;

                pushButton.Enabled = true;
                switchButton.Enabled = true;
                temperatureTextBox.Text = "";
                shortTextBox.Text = "";
                floatTextBox.Text = "";
                pullDataTimer.Start();
                caseTimer.Start();
                shortTimer.Start();
                floatTimer.Start();
                alarmTimer.Start();
            }
            else
            {
                MessageBox.Show("PLC bağlantısı kurulamadı. Lütfen bağlantınızı kontrol edin.");
                connectionLabel.Text = "Bağlanamadı.";
                connectionLabel.ForeColor = Color.Red;
            }

            */

            // Otomatik olarak sütun genişliğini ayarlama
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT KayitAdi, DegerFloat, DegerShort FROM Table_1";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
            /* private void disconnect_button_Click(object sender, EventArgs e)
             {
                 pullDataTimer.Stop();
                 shortTimer.Stop();
                 floatTimer.Stop();
                 pushTimer.Stop();
                 switchTimer.Stop();
                 caseTimer.Stop();
                 floatTimer.Stop();
                 plc1.Close();
                 if (plc1.IsConnected == false)
                 {
                     connectionLabel.Text = "Baglanti kesildi.";
                     connectionLabel.ForeColor = Color.Red;

                     pushButton.BackColor = Color.White;
                     pushButton.Enabled = false;
                     switchButton.BackColor = Color.White;
                     switchButton.Enabled = false;
                     caseButton.Enabled = false;
                     motorLabel.Text = "MOTOR";
                     motorLabel.ForeColor = Color.Black;
                     temperatureTextBox.Text = "NaN";
                     shortLabel.Text = "SHORT DEĞER GİRİNİZ";
                     shortTextBox.Text = "NaN";
                     floatLabel.Text = "FLOAT DEĞER GİRİNİZ";
                     floatTextBox.Text = "NaN";
                     caseLabel.Text = "DURUM:";
                     caseLabel.ForeColor = Color.Black;
                 }
                 else 
                 {
                     MessageBox.Show("PLC bağlantısı kesilemedi.");
                 }
             }
            */
            private void pull_data_timer_Tick(object sender, EventArgs e)
        {
            bool motor = (bool)plc1.Read("M0.2");
            ushort sicaklik = (ushort)plc1.Read("MW200");
            temperatureTextBox.Text = sicaklik.ToString();

            if (motor == true)
            {
                motorLabel.Text = "Motor aktif.";
                motorLabel.ForeColor = Color.Green;
            }
            else if (motor == false)
            {
                motorLabel.Text = "Motor aktif degil.";
                motorLabel.ForeColor = Color.Red;
            }
        }
        private void short_timer_Tick(object sender, EventArgs e)
        {
            shortTextBox.Text = plc1.Read("DB1.DBW4").ToString();
        }
        private void float_timer_Tick(object sender, EventArgs e)
        {
            var rawValue = plc1.Read("DB1.DBD8");
            float floatValue = (float)S7.Net.Types.Double.FromDWord((uint)rawValue);
            floatTextBox.Text = floatValue.ToString();

        }
        private void pushButton_MouseDown(object sender, MouseEventArgs e)
        {
            plc1.Write("DB1.DBX16.2", true);
            bool bValue = (bool)plc1.Read("DB1.DBX16.2");
            if (bValue == true)
            {
                pushButton.BackColor = Color.Green;
            }
            else
            {
                pushButton.BackColor = Color.White;
            }
        }
        private void pushButton_MouseUp(object sender, MouseEventArgs e)
        {
            plc1.Write("DB1.DBX16.2", false);
            bool bValue = (bool)plc1.Read("DB1.DBX16.2");
            if (bValue == false)
            {
                pushButton.BackColor = Color.White;
            }

        }
        private void switchButton_Click(object sender, EventArgs e)
        {
            bool currentValue = (bool)plc1.Read("DB1.DBX16.4");

            // Durumu tersine çevir (toggle)
            bool newValue = !currentValue;

            // Yeni değer
            plc1.Write("DB1.DBX16.4", newValue);

            // Buton renk
            if (newValue == true)
            {
                switchButton.BackColor = Color.Green;
            }
            else
            {
                switchButton.BackColor = Color.Red;
            }
            switchTimer.Start();
        }

        private void switchTimer_Tick(object sender, EventArgs e)
        {
            bool bValue = (bool)plc1.Read("DB1.DBX16.4");
            if (bValue == true)
            {
                switchButton.BackColor = Color.Green;
            }
            else
            {
                switchButton.BackColor = Color.Red;
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            pushTimer.Start();
        }

        private void pushTimer_Tick(object sender, EventArgs e)
        {
            bool bValue = (bool)plc1.Read("DB1.DBX16.2");
            if (bValue == true)
            {
                pushButton.BackColor = Color.Green;
            }
            else
            {
                pushButton.BackColor = Color.White;
            }
        }

        private void caseTimer_Tick(object sender, EventArgs e)
        {
            bool caseValue = (bool)plc1.Read("DB1.DBX16.5");

            if (caseValue)
            {
                caseButton.Enabled = true;
                caseLabel.Text = "Aktif";
                caseLabel.ForeColor = Color.Green;
            }
            else
            {
                caseButton.Enabled = false;
                caseLabel.Text = "Pasif";
                caseLabel.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();

        }

        private void sendDataScreen_Click(object sender, EventArgs e)
        {
            sendDataPanel.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();
        }

        private void homePanel_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pullDataPanel.BringToFront();

        }
        private void shortTextBox_Click(object sender, EventArgs e)
        {
            shortTimer.Stop();
        }
        private void floatTextBox_Click(Object sender, EventArgs e)
        {
            floatTimer.Stop();
        }

        private void ipBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string ipAddress = ipBox.Text;

                if (System.Net.IPAddress.TryParse(ipAddress, out _))
                {
                    plc1 = new Plc(CpuType.S71200, ipAddress, 0, 1);

                    try
                    {
                        plc1.Open();

                        if (plc1.IsConnected)
                        {
                            MessageBox.Show("Yeni IP adresi ile bağlantı başarılı!");
                            connectionLabel.Text = "Bağlandı.";
                            connectionLabel.ForeColor = Color.Green;
                            pushButton.Enabled = true;
                            switchButton.Enabled = true;
                            temperatureTextBox.Text = "";
                            shortTextBox.Text = "";
                            floatTextBox.Text = "";
                            pullDataTimer.Start();
                            caseTimer.Start();
                            shortTimer.Start();
                            floatTimer.Start();
                            alarmTimer.Start();
                        }
                        else
                        {
                            MessageBox.Show("Bağlantı kurulamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        pullDataTimer.Stop();
                        shortTimer.Stop();
                        floatTimer.Stop();
                        pushTimer.Stop();
                        switchTimer.Stop();
                        caseTimer.Stop();
                        alarmTimer.Stop();
                        MessageBox.Show($"Bağlantı hatası: {ex.Message}");
                        connectionLabel.Text = "Bağlanamadı.";
                        connectionLabel.ForeColor = Color.Red;
                    }
                }
                else
                {
                    pullDataTimer.Stop();
                    shortTimer.Stop();
                    floatTimer.Stop();
                    pushTimer.Stop();
                    switchTimer.Stop();
                    caseTimer.Stop();
                    alarmTimer.Stop();
                    MessageBox.Show("Lütfen geçerli bir IP adresi girin.");
                }
            }
        }

        private void shortTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ushort fıtıfıtı;
            ushort.TryParse(shortTextBox.Text, out fıtıfıtı);
            if (e.KeyCode == Keys.Enter) {
                  plc1.Write("DB1.DBW4", fıtıfıtı);
                shortLabel.Text = "Veri gönderildi.";

                shortTimer.Start();

            }

        }

        private void floatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            float floatValue;
            float.TryParse(floatTextBox.Text, out floatValue);
            if (e.KeyCode == Keys.Enter)
            {
                plc1.Write("DB1.DBW8", floatValue);
                floatLabel.Text = "Veri gönderildi.";

                floatTimer.Start();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plc1.Write("M0.7",1);
            plc1.Write("M0.7", 0);
            dataGridView1.Rows.Clear();
            addedAlarms.Clear();


        }

        private HashSet<string> addedAlarms = new HashSet<string>();

        private void alarm_Tick(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Alarm";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

            if ((bool)plc1.Read("M0.4") == true && !addedAlarms.Contains("Alarm1"))
            {
                string[] row1 = new string[] { "1", "Alarm1" };
                dataGridView1.Rows.Add(row1);
                addedAlarms.Add("Alarm1");
            }
            if ((bool)plc1.Read("M0.6") == true && !addedAlarms.Contains("Alarm2"))
            {
                string[] row2 = new string[] { "2", "Alarm Test 2" };
                dataGridView1.Rows.Add(row2);
                addedAlarms.Add("Alarm2");
            }
            if ((bool)plc1.Read("M1.0") == true && !addedAlarms.Contains("Alarm3"))
            {
                string[] row3 = new string[] { "3", "Motor Alarm " };
                dataGridView1.Rows.Add(row3);
                addedAlarms.Add("Alarm3");
            }
            if ((bool)plc1.Read("M1.1") == true)
            {
                alarmPanel.Visible = true;
                alarmLabel.Visible = !alarmLabel.Visible;
                alarmPanel.BringToFront();
            }
            else
            {
                alarmPanel.Visible = false;
            }
        }

        private void receteButton_Click(object sender, EventArgs e)
        {
            recipePanel.BringToFront();
        }

        //bokluk var çöz........................................................................................................................
        /// <summary>
        /// 
        /// 
        ///  
        /// 
        /// 
        /// 
        /// </summary>

        private string selectedKayitAdi;
        private float selectedFloatValue;
        private short selectedShortValue;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // KayitAdi kontrolü
                if (row.Cells["KayitAdi"].Value != null)
                {
                    selectedKayitAdi = row.Cells["KayitAdi"].Value.ToString().Trim();
                }
                else
                {
                    selectedKayitAdi = "NULL";
                }

                // DegerFloat kontrolü
                if (row.Cells["DegerFloat"].Value != null)
                {
                    var cellValue = row.Cells["DegerFloat"].Value.ToString().Replace(",", ".").Trim();
                    if (float.TryParse(cellValue, NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
                    {
                        selectedFloatValue = result;
                    }
                    else
                    {
                        selectedFloatValue = 0;
                    }
                }
                else
                {
                    selectedFloatValue = 0;
                }

                // DegerShort kontrolü
                if (row.Cells["DegerShort"].Value != null)
                {
                    var cellValue = row.Cells["DegerShort"].Value.ToString().Trim();
                    if (short.TryParse(cellValue, out short result))
                    {
                        selectedShortValue = result;
                    }
                    else
                    {
                        selectedShortValue = 0;
                    }
                }
                else
                {
                    selectedShortValue = 0;
                }
            }
        }


        private void dbDataSendButton_Click(object sender, EventArgs e)
        {
            if (plc1 != null && plc1.IsConnected)
            {
                // PLC'ye float ve short değerlerini yazın
                plc1.Write("DB1.DBD8", selectedFloatValue);
                plc1.Write("DB1.DBW4", selectedShortValue);

                MessageBox.Show($"{selectedKayitAdi} parametreleri başarıyla gönderildi.");
            }
            else
            {
                MessageBox.Show("PLC bağlantısı kurulamadı!");
            }
        }

        private void dbDataPullButton_Click(object sender, EventArgs e)
        {
            if (plc1 != null && plc1.IsConnected)
            {
                // PLC'den float ve short değerlerini oku
                float plcFloatValue = Convert.ToSingle(plc1.Read("DB1.DBD8"));
                short plcShortValue = Convert.ToInt16(plc1.Read("DB1.DBW4"));

                // Float ve Short değerlerini string'e dönüştür
                string floatAsString = plcFloatValue.ToString();
                string shortAsString = plcShortValue.ToString();

                // Çekilen verileri pop-up olarak göster
                MessageBox.Show($"Float Değeri: {floatAsString}\nShort Değeri: {shortAsString}", "Makineden Çekilen Parametreler");
            }
            else
            {
                MessageBox.Show("PLC bağlantısı kurulamadı!");
            }
        }

        private void newReceteButton_Click(object sender, EventArgs e)
        {
            // SQL bağlantısını ve PLC nesnesini ileterek yeni receteForm oluşturun
            recipeForm form = new recipeForm(plc1, sqlConnection);
            form.Show();  // Formu pop-up (modal) olarak göster

        }

        private void recipeDelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Reçeteyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DeleteRecipeFromDatabase(selectedKayitAdi);
            }
        }
        private void DeleteRecipeFromDatabase(string kayitAdi)
        {
            string connectionString = "YourConnectionStringHere"; // Veritabanı bağlantı dizesi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Recipes WHERE KayitAdi = @KayitAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KayitAdi", kayitAdi);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Silme işleminden sonra DataGridView'i güncelleyin
            LoadRecipes();
        }

        // Reçeteleri DataGridView'e yükleme fonksiyonu
        private void LoadRecipes()
        {
            string connectionString = "YourConnectionStringHere"; // Veritabanı bağlantı dizesi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Recipes";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void dbTimer_Tick(object sender, EventArgs e)
        {

        }

        //form

    }

    //namespace

}

