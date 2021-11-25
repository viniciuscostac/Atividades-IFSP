
namespace TP04_DESKTOP
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxSubtitle = new System.Windows.Forms.TextBox();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.txtBoxSummary = new System.Windows.Forms.TextBox();
            this.lbSummary = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(72, 80);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(123, 77);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(41, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(67, 114);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 13);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Título";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(123, 111);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(252, 20);
            this.txtBoxTitle.TabIndex = 3;
            // 
            // txtBoxSubtitle
            // 
            this.txtBoxSubtitle.Location = new System.Drawing.Point(123, 145);
            this.txtBoxSubtitle.Name = "txtBoxSubtitle";
            this.txtBoxSubtitle.Size = new System.Drawing.Size(665, 20);
            this.txtBoxSubtitle.TabIndex = 5;
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Location = new System.Drawing.Point(67, 148);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Size = new System.Drawing.Size(50, 13);
            this.lbSubtitle.TabIndex = 4;
            this.lbSubtitle.Text = "Subtítulo";
            // 
            // txtBoxSummary
            // 
            this.txtBoxSummary.Location = new System.Drawing.Point(123, 179);
            this.txtBoxSummary.Multiline = true;
            this.txtBoxSummary.Name = "txtBoxSummary";
            this.txtBoxSummary.Size = new System.Drawing.Size(665, 68);
            this.txtBoxSummary.TabIndex = 7;
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Location = new System.Drawing.Point(67, 182);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(46, 13);
            this.lbSummary.TabIndex = 6;
            this.lbSummary.Text = "Resumo";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(123, 261);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(665, 20);
            this.txtBoxAuthor.TabIndex = 9;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(72, 264);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(32, 13);
            this.lbAuthor.TabIndex = 8;
            this.lbAuthor.Text = "Autor";
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(123, 295);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(145, 20);
            this.txtBoxStatus.TabIndex = 11;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(72, 298);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Status";
            // 
            // lbBook
            // 
            this.lbBook.AutoSize = true;
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.Location = new System.Drawing.Point(360, 9);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(86, 37);
            this.lbBook.TabIndex = 12;
            this.lbBook.Text = "Livro";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 366);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 43);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(660, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Inserir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.txtBoxSummary);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.txtBoxSubtitle);
            this.Controls.Add(this.lbSubtitle);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lbId);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxSubtitle;
        private System.Windows.Forms.Label lbSubtitle;
        private System.Windows.Forms.TextBox txtBoxSummary;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txtBoxStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}