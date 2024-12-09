namespace WinFormsAppToDoList2025
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            try
            {
                InitializeComponent();
            }

            catch
            {
                MessageBox.Show("Bilinmeyen hata!");

            }

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string hedef = textBoxHedef.Text;
            listBoxYapilacaklar.Items.Add(hedef);

        }

        private void buttonTamamla_Click(object sender, EventArgs e)
        {

            if (listBoxYapilacaklar.SelectedItem != null)
            {
                listBoxTamamlananlar.Items.Add(listBoxYapilacaklar.SelectedItem.ToString());
                listBoxYapilacaklar.Items.RemoveAt(listBoxYapilacaklar.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seçim yapýnýz!");

            }
        }
        private void buttonGeriAl_Click(object sender, EventArgs e)
            {
                if (listBoxTamamlananlar.SelectedItem != null)
                {
                    listBoxYapilacaklar.Items.Add(listBoxTamamlananlar.SelectedItem.ToString());
                    listBoxTamamlananlar.Items.RemoveAt(listBoxTamamlananlar.SelectedIndex);
                }
            else
            {
                MessageBox.Show("Seçim yapýnýz!");

            }
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
       
                if (listBoxTamamlananlar.SelectedItem!=null)
                {
                    listBoxTamamlananlar.Items.RemoveAt(listBoxTamamlananlar.SelectedIndex);
                }
                else if (listBoxYapilacaklar.SelectedItem!=null)
                {
                    listBoxYapilacaklar.Items.RemoveAt(listBoxYapilacaklar.SelectedIndex);
                }
            else
            {
                MessageBox.Show("seçim yapýnýz");
            }


            

  
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBoxYapilacaklar.Items.Clear();
            listBoxTamamlananlar.Items.Clear();
        }
    }
}
