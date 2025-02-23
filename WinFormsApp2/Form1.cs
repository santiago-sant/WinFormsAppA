using System.Linq.Expressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lbllMessage_Click(object sender, EventArgs e)
        {
            lbllMessage.Text = "Hello World ";
        }
    }
}
