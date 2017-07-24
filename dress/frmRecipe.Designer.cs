namespace dress
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.panLista = new System.Windows.Forms.Panel();
            this.lblScor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.chkIngrediente = new System.Windows.Forms.CheckedListBox();
            this.lstAlese = new System.Windows.Forms.ListBox();
            this.panImg = new System.Windows.Forms.Panel();
            this.cboRetete = new System.Windows.Forms.ComboBox();
            this.pbFinal = new System.Windows.Forms.PictureBox();
            this.pbTava = new System.Windows.Forms.PictureBox();
            this.panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTava)).BeginInit();
            this.SuspendLayout();
            // 
            // panLista
            // 
            this.panLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLista.BackgroundImage")));
            this.panLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panLista.Controls.Add(this.lblScor);
            this.panLista.Controls.Add(this.label1);
            this.panLista.Controls.Add(this.btnVerify);
            this.panLista.Controls.Add(this.chkIngrediente);
            this.panLista.Location = new System.Drawing.Point(33, 68);
            this.panLista.Name = "panLista";
            this.panLista.Size = new System.Drawing.Size(239, 355);
            this.panLista.TabIndex = 2;
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblScor.Location = new System.Drawing.Point(194, 322);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(13, 13);
            this.lblScor.TabIndex = 4;
            this.lblScor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(130, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your score:";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(82, 285);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // chkIngrediente
            // 
            this.chkIngrediente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkIngrediente.FormattingEnabled = true;
            this.chkIngrediente.Location = new System.Drawing.Point(14, 37);
            this.chkIngrediente.Name = "chkIngrediente";
            this.chkIngrediente.Size = new System.Drawing.Size(206, 304);
            this.chkIngrediente.TabIndex = 1;
            // 
            // lstAlese
            // 
            this.lstAlese.FormattingEnabled = true;
            this.lstAlese.Location = new System.Drawing.Point(12, 10);
            this.lstAlese.Name = "lstAlese";
            this.lstAlese.Size = new System.Drawing.Size(79, 30);
            this.lstAlese.TabIndex = 3;
            this.lstAlese.Visible = false;
            // 
            // panImg
            // 
            this.panImg.BackColor = System.Drawing.Color.Linen;
            this.panImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panImg.Location = new System.Drawing.Point(293, 68);
            this.panImg.Name = "panImg";
            this.panImg.Size = new System.Drawing.Size(531, 506);
            this.panImg.TabIndex = 2;
            // 
            // cboRetete
            // 
            this.cboRetete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRetete.FormattingEnabled = true;
            this.cboRetete.Location = new System.Drawing.Point(33, 46);
            this.cboRetete.Name = "cboRetete";
            this.cboRetete.Size = new System.Drawing.Size(220, 21);
            this.cboRetete.TabIndex = 4;
            this.cboRetete.SelectedIndexChanged += new System.EventHandler(this.cboRetete_SelectedIndexChanged);
            // 
            // pbFinal
            // 
            this.pbFinal.BackColor = System.Drawing.Color.Transparent;
            this.pbFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFinal.Location = new System.Drawing.Point(15, 429);
            this.pbFinal.Name = "pbFinal";
            this.pbFinal.Size = new System.Drawing.Size(257, 119);
            this.pbFinal.TabIndex = 5;
            this.pbFinal.TabStop = false;
            // 
            // pbTava
            // 
            this.pbTava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTava.BackgroundImage")));
            this.pbTava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTava.Location = new System.Drawing.Point(12, 481);
            this.pbTava.Name = "pbTava";
            this.pbTava.Size = new System.Drawing.Size(257, 130);
            this.pbTava.TabIndex = 0;
            this.pbTava.TabStop = false;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(836, 586);
            this.Controls.Add(this.pbTava);
            this.Controls.Add(this.pbFinal);
            this.Controls.Add(this.cboRetete);
            this.Controls.Add(this.lstAlese);
            this.Controls.Add(this.panImg);
            this.Controls.Add(this.panLista);
            this.Name = "frmRecipe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panLista.ResumeLayout(false);
            this.panLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panLista;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.CheckedListBox chkIngrediente;
        private System.Windows.Forms.ListBox lstAlese;
        private System.Windows.Forms.Panel panImg;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRetete;
        private System.Windows.Forms.PictureBox pbFinal;
        private System.Windows.Forms.PictureBox pbTava;
    }
}

