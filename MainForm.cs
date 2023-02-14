using eCI.service.wanted_people;
using System.Windows.Forms;

namespace eCI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            IWantedPeopleService service = InstanceFactory.GetInstanceOfType<IWantedPeopleService>();

            System.Console.WriteLine(" >> service: " + service);

            service.CrawlWantedPeople();
        }
    }
}
