namespace TestandoStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder Mensagem = new System.Text.StringBuilder();

            int iConta = 0;

            for (iConta = 0; iConta <= richTextBox1.Lines.Count() - 1; iConta++)
            {
                Mensagem.Append(richTextBox1.Lines[iConta].ToString() + " ");
            }

            MessageBox.Show(Mensagem.ToString(), " TEXTO ", MessageBoxButtons.OK);
        }
    }
}