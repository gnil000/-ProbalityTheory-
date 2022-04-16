namespace ProbalityTheory
{
    public partial class Wait_Window : Form
    {
        public Action Worker { get; set; }

        public Wait_Window(Action worker)
        {
            InitializeComponent();
            if(worker==null)
                throw new ArgumentNullException();
            Worker = worker;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Начинаем новый поток
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
 
    }
}
