using System.Data;
using System.Data.SqlClient;

namespace GettingQueryResultInXMLType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=***********;Database=*********;Trusted_Connection=True;");
            SqlDataAdapter dap = new SqlDataAdapter("Select * from Urunler", baglanti);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            FileStream fs = new FileStream("Urunler.xml", FileMode.OpenOrCreate, FileAccess.Write);
            ds.WriteXml(fs);
            fs.Close();
            MessageBox.Show("Ýþlem Tamam");
        }
    }
}