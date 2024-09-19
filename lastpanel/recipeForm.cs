using S7.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lastpanel
{
    public partial class recipeForm : Form
    {
        Plc plc1;
        private SqlConnection sqlConnection;

        // Yapıcı metod, MainForm'dan plc1 nesnesini alıyor
        public recipeForm(Plc plc, SqlConnection connection)
        {
            InitializeComponent();
            this.plc1 = plc;
            this.sqlConnection = connection;
        }

        private void receteForm_Load(object sender, EventArgs e)
        {
        }

        private void pullDataButton_Click(object sender, EventArgs e)
        {
            if (plc1 != null && plc1.IsConnected)
            {
                try
                {
                    floatValTextBox.Text = plc1.Read("DB1.DBD8").ToString();
                    shortValTextBox.Text = plc1.Read("DB1.DBW4").ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PLC bağlantısı yok veya plc1 nesnesi null!");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string receteAdi = recipeNameTextBox.Text;
            float floatValue = float.Parse(floatValTextBox.Text);
            short shortValue = short.Parse(shortValTextBox.Text);

            // sqlConnection yapıcıdan alındı, burada kullanılıyor
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO ReceteTable (ReceteAdi, FloatDeger, ShortDeger) VALUES (@ReceteAdi, @FloatDeger, @ShortDeger)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@ReceteAdi", receteAdi);
                        command.Parameters.AddWithValue("@FloatDeger", floatValue);
                        command.Parameters.AddWithValue("@ShortDeger", shortValue);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Reçete başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Reçete kaydedilemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("SQL bağlantısı yok!");
            }
        }
    
    }
}
