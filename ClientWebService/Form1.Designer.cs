namespace ClientWebService
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.txtPostPrezzo = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostNome = new System.Windows.Forms.TextBox();
            this.txtPostCategoria = new System.Windows.Forms.TextBox();
            this.txtPostSviluppatore = new System.Windows.Forms.TextBox();
            this.txtPostPubblicatore = new System.Windows.Forms.TextBox();
            this.pnlPostPut = new System.Windows.Forms.Panel();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnPostIndietro = new System.Windows.Forms.Button();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblPost5 = new System.Windows.Forms.Label();
            this.lblPost4 = new System.Windows.Forms.Label();
            this.lblPost3 = new System.Windows.Forms.Label();
            this.lblPost2 = new System.Windows.Forms.Label();
            this.lblPost1 = new System.Windows.Forms.Label();
            this.btnApriPost = new System.Windows.Forms.Button();
            this.btnApriPut = new System.Windows.Forms.Button();
            this.lblPut = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPostPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(12, 41);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(134, 20);
            this.txtRecord.TabIndex = 0;
            // 
            // txtPostPrezzo
            // 
            this.txtPostPrezzo.Location = new System.Drawing.Point(96, 75);
            this.txtPostPrezzo.Name = "txtPostPrezzo";
            this.txtPostPrezzo.Size = new System.Drawing.Size(100, 20);
            this.txtPostPrezzo.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(134, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(112, 179);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(84, 23);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Esegui POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 340);
            this.dataGridView1.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 64);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Inserire id record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lascia vuoto per get all";
            // 
            // txtPostNome
            // 
            this.txtPostNome.Location = new System.Drawing.Point(96, 49);
            this.txtPostNome.Name = "txtPostNome";
            this.txtPostNome.Size = new System.Drawing.Size(100, 20);
            this.txtPostNome.TabIndex = 8;
            // 
            // txtPostCategoria
            // 
            this.txtPostCategoria.Location = new System.Drawing.Point(96, 101);
            this.txtPostCategoria.Name = "txtPostCategoria";
            this.txtPostCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtPostCategoria.TabIndex = 9;
            // 
            // txtPostSviluppatore
            // 
            this.txtPostSviluppatore.Location = new System.Drawing.Point(96, 127);
            this.txtPostSviluppatore.Name = "txtPostSviluppatore";
            this.txtPostSviluppatore.Size = new System.Drawing.Size(100, 20);
            this.txtPostSviluppatore.TabIndex = 10;
            // 
            // txtPostPubblicatore
            // 
            this.txtPostPubblicatore.Location = new System.Drawing.Point(96, 153);
            this.txtPostPubblicatore.Name = "txtPostPubblicatore";
            this.txtPostPubblicatore.Size = new System.Drawing.Size(100, 20);
            this.txtPostPubblicatore.TabIndex = 11;
            // 
            // pnlPostPut
            // 
            this.pnlPostPut.Controls.Add(this.btnPut);
            this.pnlPostPut.Controls.Add(this.btnPostIndietro);
            this.pnlPostPut.Controls.Add(this.lblPost);
            this.pnlPostPut.Controls.Add(this.lblPost5);
            this.pnlPostPut.Controls.Add(this.lblPost4);
            this.pnlPostPut.Controls.Add(this.lblPost3);
            this.pnlPostPut.Controls.Add(this.lblPost2);
            this.pnlPostPut.Controls.Add(this.lblPost1);
            this.pnlPostPut.Controls.Add(this.btnPost);
            this.pnlPostPut.Controls.Add(this.txtPostPubblicatore);
            this.pnlPostPut.Controls.Add(this.txtPostNome);
            this.pnlPostPut.Controls.Add(this.txtPostSviluppatore);
            this.pnlPostPut.Controls.Add(this.txtPostPrezzo);
            this.pnlPostPut.Controls.Add(this.txtPostCategoria);
            this.pnlPostPut.Location = new System.Drawing.Point(279, 121);
            this.pnlPostPut.Name = "pnlPostPut";
            this.pnlPostPut.Size = new System.Drawing.Size(218, 219);
            this.pnlPostPut.TabIndex = 13;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(112, 179);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(84, 23);
            this.btnPut.TabIndex = 26;
            this.btnPut.Text = "Esegui PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnPostIndietro
            // 
            this.btnPostIndietro.Location = new System.Drawing.Point(24, 179);
            this.btnPostIndietro.Name = "btnPostIndietro";
            this.btnPostIndietro.Size = new System.Drawing.Size(84, 23);
            this.btnPostIndietro.TabIndex = 25;
            this.btnPostIndietro.Text = "Indietro";
            this.btnPostIndietro.UseVisualStyleBackColor = true;
            this.btnPostIndietro.Click += new System.EventHandler(this.btnPostIndietro_Click);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(20, 11);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(187, 24);
            this.lblPost.TabIndex = 24;
            this.lblPost.Text = "Inserisci valori record";
            // 
            // lblPost5
            // 
            this.lblPost5.AutoSize = true;
            this.lblPost5.Location = new System.Drawing.Point(21, 156);
            this.lblPost5.Name = "lblPost5";
            this.lblPost5.Size = new System.Drawing.Size(69, 13);
            this.lblPost5.TabIndex = 23;
            this.lblPost5.Text = "Pubblicatore:";
            // 
            // lblPost4
            // 
            this.lblPost4.AutoSize = true;
            this.lblPost4.Location = new System.Drawing.Point(21, 130);
            this.lblPost4.Name = "lblPost4";
            this.lblPost4.Size = new System.Drawing.Size(69, 13);
            this.lblPost4.TabIndex = 22;
            this.lblPost4.Text = "Sviluppatore:";
            // 
            // lblPost3
            // 
            this.lblPost3.AutoSize = true;
            this.lblPost3.Location = new System.Drawing.Point(35, 104);
            this.lblPost3.Name = "lblPost3";
            this.lblPost3.Size = new System.Drawing.Size(55, 13);
            this.lblPost3.TabIndex = 21;
            this.lblPost3.Text = "Categoria:";
            // 
            // lblPost2
            // 
            this.lblPost2.AutoSize = true;
            this.lblPost2.Location = new System.Drawing.Point(48, 78);
            this.lblPost2.Name = "lblPost2";
            this.lblPost2.Size = new System.Drawing.Size(42, 13);
            this.lblPost2.TabIndex = 20;
            this.lblPost2.Text = "Prezzo:";
            // 
            // lblPost1
            // 
            this.lblPost1.AutoSize = true;
            this.lblPost1.Location = new System.Drawing.Point(52, 52);
            this.lblPost1.Name = "lblPost1";
            this.lblPost1.Size = new System.Drawing.Size(38, 13);
            this.lblPost1.TabIndex = 19;
            this.lblPost1.Text = "Nome:";
            // 
            // btnApriPost
            // 
            this.btnApriPost.Location = new System.Drawing.Point(190, 12);
            this.btnApriPost.Name = "btnApriPost";
            this.btnApriPost.Size = new System.Drawing.Size(134, 23);
            this.btnApriPost.TabIndex = 14;
            this.btnApriPost.Text = "POST";
            this.btnApriPost.UseVisualStyleBackColor = true;
            this.btnApriPost.Click += new System.EventHandler(this.btnApriPost_Click);
            // 
            // btnApriPut
            // 
            this.btnApriPut.Location = new System.Drawing.Point(363, 12);
            this.btnApriPut.Name = "btnApriPut";
            this.btnApriPut.Size = new System.Drawing.Size(134, 23);
            this.btnApriPut.TabIndex = 15;
            this.btnApriPut.Text = "PUT";
            this.btnApriPut.UseVisualStyleBackColor = true;
            this.btnApriPut.Click += new System.EventHandler(this.btnApriPut_Click);
            // 
            // lblPut
            // 
            this.lblPut.AutoSize = true;
            this.lblPut.Location = new System.Drawing.Point(360, 64);
            this.lblPut.Name = "lblPut";
            this.lblPut.Size = new System.Drawing.Size(85, 13);
            this.lblPut.TabIndex = 16;
            this.lblPut.Text = "Inserire id record";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(535, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(363, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(535, 41);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(134, 20);
            this.txtDeleteId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Inserire id record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeleteId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPut);
            this.Controls.Add(this.btnApriPut);
            this.Controls.Add(this.btnApriPost);
            this.Controls.Add(this.pnlPostPut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPostPut.ResumeLayout(false);
            this.pnlPostPut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.TextBox txtPostPrezzo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostNome;
        private System.Windows.Forms.TextBox txtPostCategoria;
        private System.Windows.Forms.TextBox txtPostSviluppatore;
        private System.Windows.Forms.TextBox txtPostPubblicatore;
        private System.Windows.Forms.Panel pnlPostPut;
        private System.Windows.Forms.Label lblPost5;
        private System.Windows.Forms.Label lblPost4;
        private System.Windows.Forms.Label lblPost3;
        private System.Windows.Forms.Label lblPost2;
        private System.Windows.Forms.Label lblPost1;
        private System.Windows.Forms.Button btnPostIndietro;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Button btnApriPost;
        private System.Windows.Forms.Button btnApriPut;
        private System.Windows.Forms.Label lblPut;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label2;
    }
}

