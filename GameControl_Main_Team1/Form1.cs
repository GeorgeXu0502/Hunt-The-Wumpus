namespace WumpusTestGameControl
{
    public partial class Form1 : Form
    {
        private GameControl _GameControl;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            _GameControl = new GameControl();
        }
    }
}
