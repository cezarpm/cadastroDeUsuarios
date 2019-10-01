namespace CadastrodeUsuarios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.id_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabela_produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(13, 28);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 20);
            this.id_box.TabIndex = 0;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(119, 28);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 20);
            this.name_box.TabIndex = 1;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(331, 28);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(100, 20);
            this.price_box.TabIndex = 3;
            // 
            // desc_box
            // 
            this.desc_box.Location = new System.Drawing.Point(225, 28);
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(100, 20);
            this.desc_box.TabIndex = 2;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(437, 26);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Adicionar";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço";
            // 
            // tabela_produtos
            // 
            this.tabela_produtos.AllowUserToAddRows = false;
            this.tabela_produtos.AllowUserToDeleteRows = false;
            this.tabela_produtos.AllowUserToResizeColumns = false;
            this.tabela_produtos.AllowUserToResizeRows = false;
            this.tabela_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_produtos.EnableHeadersVisualStyles = false;
            this.tabela_produtos.Location = new System.Drawing.Point(13, 71);
            this.tabela_produtos.Name = "tabela_produtos";
            this.tabela_produtos.ReadOnly = true;
            this.tabela_produtos.RowHeadersVisible = false;
            this.tabela_produtos.Size = new System.Drawing.Size(495, 334);
            this.tabela_produtos.TabIndex = 11;
            this.tabela_produtos.SelectionChanged += new System.EventHandler(this.Tabela_produtos_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 417);
            this.Controls.Add(this.tabela_produtos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.desc_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Name = "Form1";
            this.Text = "Cadastrar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.tabela_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox desc_box;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabela_produtos;
    }
}

