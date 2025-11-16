using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class AddSaleForm : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly IClientRepository _clientRepository;
        private Action _loadSales;

        public AddSaleForm(ISaleRepository saleRepository,
                         IRaceRepository raceRepository,
                         IClientRepository clientRepository,
                         Action loadSales)
        {
            InitializeComponent();
            _saleRepository = saleRepository;
            _raceRepository = raceRepository;
            _clientRepository = clientRepository;
            _loadSales = loadSales;
        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {
            LoadRaces();
            LoadClients();
        }

        private void LoadRaces()
        {
            try
            {
                var races = _raceRepository.GetAll();
                raceComboBox.DataSource = races;
                raceComboBox.DisplayMember = "TripNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке рейсов: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClients()
        {
            try
            {
                var clients = _clientRepository.GetAll();
                clientComboBox.DataSource = clients;
                clientComboBox.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке клиентов: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (raceComboBox.SelectedItem == null ||
                clientComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(saleStatusInput.Text))
            {
                MessageBox.Show("Пожалуйста, выберите рейс, клиента и укажите статус продажи.",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var selectedRace = (RaceEntity)raceComboBox.SelectedItem;
                var selectedClient = (ClientEntity)clientComboBox.SelectedItem;

                var sale = new SaleEntity
                {
                    RaceId = selectedRace.RaceId,
                    DepartureDate = selectedRace.DepartureDate,
                    DepartureTime = selectedRace.DepartureTime,
                    TicketPrice = selectedRace.TicketPrice,
                    Name = selectedClient.Name,
                    Address = selectedClient.Address,
                    PhoneNumber = selectedClient.PhoneNumber,
                    SaleStatus = saleStatusInput.Text,
                    Notes = notesInput.Text,
                    CreatedAt = DateTime.Now
                };

                _saleRepository.Add(sale);
                MessageBox.Show("Продажа успешно добавлена!");
                _loadSales?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}