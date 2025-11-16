using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class UpdateSaleForm : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IRaceRepository _raceRepository;
        private readonly IClientRepository _clientRepository;
        private readonly SaleEntity _sale;
        private Action _loadSales;

        public UpdateSaleForm(ISaleRepository saleRepository,
                           IRaceRepository raceRepository,
                           IClientRepository clientRepository,
                           SaleEntity sale,
                           Action loadSales)
        {
            InitializeComponent();
            _saleRepository = saleRepository;
            _raceRepository = raceRepository;
            _clientRepository = clientRepository;
            _sale = sale;
            _loadSales = loadSales;
        }

        private void UpdateSaleForm_Load(object sender, EventArgs e)
        {
            LoadRaces();
            LoadClients();
            SetFormData();
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

        private void SetFormData()
        {
            try
            {
                if (raceComboBox.Items.Count > 0)
                {
                    foreach (var item in raceComboBox.Items)
                    {
                        if (item is RaceEntity race && race.RaceId == _sale.RaceId)
                        {
                            raceComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                if (clientComboBox.Items.Count > 0)
                {
                    foreach (var item in clientComboBox.Items)
                    {
                        if (item is ClientEntity client && client.Name == _sale.Name)
                        {
                            clientComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }

                saleStatusInput.Text = _sale.SaleStatus;
                notesInput.Text = _sale.Notes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
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

                _sale.RaceId = selectedRace.RaceId;
                _sale.DepartureDate = selectedRace.DepartureDate;
                _sale.DepartureTime = selectedRace.DepartureTime;
                _sale.TicketPrice = selectedRace.TicketPrice;
                _sale.Name = selectedClient.Name;
                _sale.Address = selectedClient.Address;
                _sale.PhoneNumber = selectedClient.PhoneNumber;
                _sale.SaleStatus = saleStatusInput.Text;
                _sale.Notes = notesInput.Text;

                _saleRepository.Update(_sale);
                MessageBox.Show("Продажа успешно обновлена!");
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