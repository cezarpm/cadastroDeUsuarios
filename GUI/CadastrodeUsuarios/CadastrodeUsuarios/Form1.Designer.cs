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
            this.id_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(12, 203);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 20);
            this.id_box.TabIndex = 0;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(118, 203);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 20);
            this.name_box.TabIndex = 1;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(330, 203);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(100, 20);
            this.price_box.TabIndex = 3;
            // 
            // desc_box
            // 
            this.desc_box.Location = new System.Drawing.Point(224, 203);
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(100, 20);
            this.desc_box.TabIndex = 2;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(436, 200);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.desc_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox desc_box;
        private System.Windows.Forms.Button submitbtn;
    }
}

