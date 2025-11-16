using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Repositories;
using UdmurtRace.DAL;

namespace UdmurtRaceForm
{
    public partial class MainForm : Form
    {
        private readonly IClientRepository _clientRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly ISaleRepository _saleRepository;

        public MainForm(
            IClientRepository clientRepository,
            IRaceRepository raceRepository,
            ISaleRepository saleRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _raceRepository = raceRepository;
            _saleRepository = saleRepository;
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientListForm(_clientRepository);
            clientForm.Show();
        }

        private void btnManageRaces_Click(object sender, EventArgs e)
        {
            var raceForm = new RaceListForm(_raceRepository);
            raceForm.Show();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            var saleForm = new SaleListForm(_saleRepository, _raceRepository, _clientRepository);
            saleForm.Show();
        }
    }
}