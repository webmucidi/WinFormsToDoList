namespace WinFormsAppToDoList2025
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
            label1 = new Label();
            textBoxHedef = new TextBox();
            label2 = new Label();
            buttonEkle = new Button();
            listBoxYapilacaklar = new ListBox();
            listBoxTamamlananlar = new ListBox();
            labelYapilacaklar = new Label();
            Tamamlananlar = new Label();
            buttonSil = new Button();
            labelSonuc = new Label();
            buttonGeriAl = new Button();
            buttonTamamla = new Button();
            buttonTemizle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zilla Slab SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 51);
            label1.Name = "label1";
            label1.Size = new Size(414, 36);
            label1.TabIndex = 0;
            label1.Text = "YAPILACAKLAR LİSTESİ 2025";
            // 
            // textBoxHedef
            // 
            textBoxHedef.Location = new Point(122, 118);
            textBoxHedef.Name = "textBoxHedef";
            textBoxHedef.Size = new Size(446, 27);
            textBoxHedef.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 121);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Hedef =>";
            // 
            // buttonEkle
            // 
            buttonEkle.Location = new Point(618, 117);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(94, 29);
            buttonEkle.TabIndex = 3;
            buttonEkle.Text = "Listeye Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // listBoxYapilacaklar
            // 
            listBoxYapilacaklar.FormattingEnabled = true;
            listBoxYapilacaklar.Location = new Point(29, 219);
            listBoxYapilacaklar.Name = "listBoxYapilacaklar";
            listBoxYapilacaklar.Size = new Size(315, 164);
            listBoxYapilacaklar.TabIndex = 4;
            // 
            // listBoxTamamlananlar
            // 
            listBoxTamamlananlar.FormattingEnabled = true;
            listBoxTamamlananlar.Location = new Point(442, 219);
            listBoxTamamlananlar.Name = "listBoxTamamlananlar";
            listBoxTamamlananlar.Size = new Size(314, 164);
            listBoxTamamlananlar.TabIndex = 4;
            // 
            // labelYapilacaklar
            // 
            labelYapilacaklar.AutoSize = true;
            labelYapilacaklar.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            labelYapilacaklar.ForeColor = Color.Olive;
            labelYapilacaklar.Location = new Point(108, 180);
            labelYapilacaklar.Name = "labelYapilacaklar";
            labelYapilacaklar.Size = new Size(171, 28);
            labelYapilacaklar.TabIndex = 5;
            labelYapilacaklar.Text = "Yapılacaklar Listesi";
            // 
            // Tamamlananlar
            // 
            Tamamlananlar.AutoSize = true;
            Tamamlananlar.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            Tamamlananlar.ForeColor = Color.DarkRed;
            Tamamlananlar.Location = new Point(488, 180);
            Tamamlananlar.Name = "Tamamlananlar";
            Tamamlananlar.Size = new Size(200, 28);
            Tamamlananlar.TabIndex = 5;
            Tamamlananlar.Text = "Tamamlananlar Listesi";
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(362, 313);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(64, 29);
            buttonSil.TabIndex = 6;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(362, 421);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(0, 20);
            labelSonuc.TabIndex = 7;
            // 
            // buttonGeriAl
            // 
            buttonGeriAl.Location = new Point(362, 266);
            buttonGeriAl.Name = "buttonGeriAl";
            buttonGeriAl.Size = new Size(64, 29);
            buttonGeriAl.TabIndex = 6;
            buttonGeriAl.Text = "<<";
            buttonGeriAl.UseVisualStyleBackColor = true;
            buttonGeriAl.Click += buttonGeriAl_Click;
            // 
            // buttonTamamla
            // 
            buttonTamamla.Location = new Point(362, 219);
            buttonTamamla.Name = "buttonTamamla";
            buttonTamamla.Size = new Size(64, 29);
            buttonTamamla.TabIndex = 6;
            buttonTamamla.Text = ">>";
            buttonTamamla.UseVisualStyleBackColor = true;
            buttonTamamla.Click += buttonTamamla_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(362, 358);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(64, 29);
            buttonTemizle.TabIndex = 6;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSonuc);
            Controls.Add(buttonTamamla);
            Controls.Add(buttonGeriAl);
            Controls.Add(buttonTemizle);
            Controls.Add(buttonSil);
            Controls.Add(Tamamlananlar);
            Controls.Add(labelYapilacaklar);
            Controls.Add(listBoxTamamlananlar);
            Controls.Add(listBoxYapilacaklar);
            Controls.Add(buttonEkle);
            Controls.Add(label2);
            Controls.Add(textBoxHedef);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxHedef;
        private Label label2;
        private Button buttonEkle;
        private ListBox listBoxYapilacaklar;
        private ListBox listBoxTamamlananlar;
        private Label labelYapilacaklar;
        private Label Tamamlananlar;
        private Button buttonSil;
        private Label labelSonuc;
        private Button buttonGeriAl;
        private Button buttonTamamla;
        private Button buttonTemizle;
    }
}
