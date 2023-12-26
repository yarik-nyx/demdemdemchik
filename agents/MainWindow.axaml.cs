using agents.db;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Media.Imaging;

namespace agents
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData() {
            List<Agent> agents = new List<Agent>();
            List<MyList> mlagents = new List<MyList>();

            agents = Helper.db.Agents.ToList();

            foreach (var item in agents) {
                mlagents.Add(new MyList
                {
                    Id = item.Id,
                    Title = "������������: " + item.Title,
                    Type = "���: " + Helper.db.Agenttypes.Where(x => x.Id == item.Agenttypeid).Select(y => y.Title).FirstOrDefault(),
                    Phone = "�������: " + item.Phone,
                    Sales = "������ �� 2018: " + Helper.db.Productsales.Where(x => x.Agentid == item.Id && x.Saledate.Year == 2018).Count().ToString(),
                    Logo = (item.Logo == null) ? new Bitmap("../../../agents/picture.png")  :  new Bitmap($"../../../{item.Logo}"),
                    Priority = "���������: " + item.Priority.ToString()
                }
                );
            }
            Lbox.ItemsSource = mlagents.ToList();


        }
    }
}