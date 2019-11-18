namespace eHHArtikelDatenbank
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView_Artikel = new System.Windows.Forms.DataGridView();
            this.btn_addArtikel = new System.Windows.Forms.Button();
            this.btn_saveEdits = new System.Windows.Forms.Button();
            this.lbl_angemeldeterUser = new System.Windows.Forms.Label();
            this.button_jaeger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Artikel)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_name.Location = new System.Drawing.Point(322, 34);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(112, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "eHH Artikeldatenbank";
            // 
            // dataGridView_Artikel
            // 
            this.dataGridView_Artikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Artikel.Location = new System.Drawing.Point(190, 73);
            this.dataGridView_Artikel.Name = "dataGridView_Artikel";
            this.dataGridView_Artikel.Size = new System.Drawing.Size(598, 365);
            this.dataGridView_Artikel.TabIndex = 1;
            // 
            // btn_addArtikel
            // 
            this.btn_addArtikel.Location = new System.Drawing.Point(12, 160);
            this.btn_addArtikel.Name = "btn_addArtikel";
            this.btn_addArtikel.Size = new System.Drawing.Size(136, 23);
            this.btn_addArtikel.TabIndex = 2;
            this.btn_addArtikel.Text = "Artikel Hinzufügen";
            this.btn_addArtikel.UseVisualStyleBackColor = true;
            this.btn_addArtikel.Click += new System.EventHandler(this.btn_addArtikel_Click);
            // 
            // btn_saveEdits
            // 
            this.btn_saveEdits.Location = new System.Drawing.Point(12, 211);
            this.btn_saveEdits.Name = "btn_saveEdits";
            this.btn_saveEdits.Size = new System.Drawing.Size(136, 23);
            this.btn_saveEdits.TabIndex = 4;
            this.btn_saveEdits.Text = "Änderungen speichern";
            this.btn_saveEdits.UseVisualStyleBackColor = true;
            this.btn_saveEdits.Click += new System.EventHandler(this.btn_saveEdits_Click);
            // 
            // lbl_angemeldeterUser
            // 
            this.lbl_angemeldeterUser.AutoSize = true;
            this.lbl_angemeldeterUser.Location = new System.Drawing.Point(12, 23);
            this.lbl_angemeldeterUser.Name = "lbl_angemeldeterUser";
            this.lbl_angemeldeterUser.Size = new System.Drawing.Size(100, 13);
            this.lbl_angemeldeterUser.TabIndex = 5;
            this.lbl_angemeldeterUser.Text = "Angemeldeter User:";
            // 
            // button_jaeger
            // 
            this.button_jaeger.Location = new System.Drawing.Point(12, 284);
            this.button_jaeger.Name = "button_jaeger";
            this.button_jaeger.Size = new System.Drawing.Size(157, 119);
            this.button_jaeger.TabIndex = 6;
            this.button_jaeger.Text = "Herr Jäger ist der Beste <3";
            this.button_jaeger.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_jaeger);
            this.Controls.Add(this.lbl_angemeldeterUser);
            this.Controls.Add(this.btn_saveEdits);
            this.Controls.Add(this.btn_addArtikel);
            this.Controls.Add(this.dataGridView_Artikel);
            this.Controls.Add(this.label_name);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Artikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridView dataGridView_Artikel;
        private System.Windows.Forms.Button btn_addArtikel;
        private System.Windows.Forms.Button btn_saveEdits;
        private System.Windows.Forms.Label lbl_angemeldeterUser;
        private System.Windows.Forms.Button button_jaeger;
    }
}

