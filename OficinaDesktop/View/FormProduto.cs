using Newtonsoft.Json;
using OficinaDesktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaDesktop.View
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            
        }
        List<Produto> produtos;
        private void FormProduto_Load(object sender, EventArgs e)
        {
            montarTabela();
            carregarTabela();
        }

        public void montarTabela()
        {
            List<string> atribudos = new Produto().GetType().GetProperties().Select(x => x.Name).ToList();
            foreach (var item in atribudos)
            {
                listView1.Columns.Add(item);
            }
        }
        public void carregarTabela()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://wmof.com.br/oficina/Controller/Controller_Produto.php");
            request.Method = "GET";
            request.Accept = "application/json";

            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                produtos = JsonConvert.DeserializeObject<List<Produto>>(reader.ReadToEnd());
            }
            foreach (var item in produtos)
            {
                ListViewItem listViewItem = listView1.Items.Add(Convert.ToString(item.Id));
                listViewItem.SubItems.Add(Convert.ToString(item.Nome));
                listViewItem.SubItems.Add(Convert.ToString(item.Marca));
                listViewItem.SubItems.Add(Convert.ToString(item.Descricao));
                listViewItem.SubItems.Add(Convert.ToString(item.Valor));
                listViewItem.SubItems.Add(Convert.ToString(item.Custo));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
