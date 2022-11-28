namespace COUNTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int theCounter = 0;
        public int i = 0;
        public string[] theCounterArray = { " " };


        private void Form1_Load(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"counter.txt");
            theCounter= int.Parse(text);

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 0)
            {
                try
                {
                    i = int.Parse( args[1]);
                }
                catch { };
            }
            theCounter += i;    
            Text = theCounter.ToString();
            theCounterArray[0] = theCounter.ToString();
            File.WriteAllLinesAsync("counter.txt", theCounterArray);
            /*  */





        }
    }
}