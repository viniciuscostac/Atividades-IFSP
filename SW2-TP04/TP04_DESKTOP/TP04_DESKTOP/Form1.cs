using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP04_DESKTOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoProduto = 1;
        BookForm bookForm = new BookForm("http://localhost:3333/api/Books");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void GetAllBooks()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Book[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o livro : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetBookById(int bookId)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + bookId.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Book>(ProdutoJsonString);
                    dgvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o livro : " + response.StatusCode);
                }
            }
        }

        private async void DeleteProduto(int bookId)
        {
            URI = txtURI.Text;
            int BookID = bookId;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}", URI, BookID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o livro: " + responseMessage.StatusCode);
                }
            }
            GetAllBooks();
        }

        private void InputBox()
        {
            string Prompt = "Informe o código do Livro.";
            string Title = "TP4";
            string Result = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Title, "9", 600, 350);
            if (Result != "")
            {
                codigoProduto = Convert.ToInt32(Result);
            }
            else
            {
                codigoProduto = -1;
            }
        }

        private void btnObterProdutos_Click(object sender, EventArgs e)
        {
            GetAllBooks();
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            InputBox();
            
            if(codigoProduto != -1)
            {
                DeleteProduto(codigoProduto);
            }
        }

        private void btnProdutosPorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoProduto != -1)
            {
                GetBookById(codigoProduto);
            }
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            bookForm.Show();
        }

        private void btnAtualizaProduto_Click(object sender, EventArgs e)
        {
            bookForm.Show();
        }
    }
}
