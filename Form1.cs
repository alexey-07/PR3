using Microsoft.VisualBasic.ApplicationServices;

namespace PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PartnersContext db = new PartnersContext())
            {
                // получаем объекты из бд и выводим на консоль
                var partners = db.Partners.ToList();
                foreach (Partner u in partners)
                {
                    label_Partners.Text+=($"{u.Id} {u.IdTypeOfPartner} {u.NameProduct} {u.Address} {u.Inn} {u.DirectorsName} {u.MobilePhone} {u.Email}  {u.Rating}\n");
                }
            }

        }
    }
}
