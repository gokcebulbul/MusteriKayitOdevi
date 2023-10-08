namespace MusteriKayitOdevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstKayıt = new ListBox();
            btnMusteriEkle = new Button();
            SuspendLayout();
            // 
            // lstKayıt
            // 
            lstKayıt.FormattingEnabled = true;
            lstKayıt.ItemHeight = 15;
            lstKayıt.Location = new Point(33, 12);
            lstKayıt.Name = "lstKayıt";
            lstKayıt.Size = new Size(245, 169);
            lstKayıt.TabIndex = 0;
            lstKayıt.SelectedIndexChanged += lstKayıt_SelectedIndexChanged;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(33, 211);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(245, 51);
            btnMusteriEkle.TabIndex = 1;
            btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 312);
            Controls.Add(btnMusteriEkle);
            Controls.Add(lstKayıt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnMusteriEkle;
        public ListBox lstKayıt;
    }
}