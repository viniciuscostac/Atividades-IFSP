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
    public partial class BookForm : Form
    {
        public BookForm(string URI)
        {
            InitializeComponent();
            this.URI = URI;
        }

        readonly string URI;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook();
            this.Hide();
        }

        private async void AddBook()
        {
            Book book = new Book();

            book.Title = txtBoxTitle.Text;
            book.Subtitle = txtBoxSubtitle.Text;
            book.Summary = txtBoxSummary.Text;
            book.Author = txtBoxAuthor.Text;
            book.Status = txtBoxStatus.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(book);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateBook();
            this.Hide();
        }

        private async void UpdateBook()
        {
            Book book = new Book();

            book.Id = int.Parse(txtBoxId.Text);
            book.Title = txtBoxTitle.Text;
            book.Subtitle = txtBoxSubtitle.Text;
            book.Summary = txtBoxSummary.Text;
            book.Author = txtBoxAuthor.Text;
            book.Status = txtBoxStatus.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + book.Id, book);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livro atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o livro : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
