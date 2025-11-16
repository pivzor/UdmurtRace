using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class UpdateRaceForm : Form
    {
        private readonly IRaceRepository _repository;
        private RaceEntity _currentRace;
        private Action _loadRaces;

        public UpdateRaceForm(IRaceRepository repository, RaceEntity race, Action loadRaces)
        {
            InitializeComponent();
            _repository = repository;
            _currentRace = race;
            _loadRaces = loadRaces;

            tripNumberInput.Text = _currentRace.TripNumber;
            departureDateInput.Text = _currentRace.DepartureDate;
            departureTimeInput.Text = _currentRace.DepartureTime;
            destinationInput.Text = _currentRace.Destination;
            ticketPriceInput.Text = _currentRace.TicketPrice.ToString();
            totalSeatsInput.Text = _currentRace.TotalSeats.ToString();
            tripDescriptionInput.Text = _currentRace.TripDescription;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tripNumberInput.Text) ||
                string.IsNullOrWhiteSpace(departureDateInput.Text) ||
                string.IsNullOrWhiteSpace(departureTimeInput.Text) ||
                string.IsNullOrWhiteSpace(destinationInput.Text))
            {
                MessageBox.Show("Номер рейса, дата отправления, время отправления и место назначения не могут быть пустыми.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(ticketPriceInput.Text, out decimal ticketPrice))
            {
                MessageBox.Show("Введите корректную цену билета.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(totalSeatsInput.Text, out int totalSeats))
            {
                MessageBox.Show("Введите корректное количество мест.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _currentRace.TripNumber = tripNumberInput.Text;
                _currentRace.DepartureDate = departureDateInput.Text;
                _currentRace.DepartureTime = departureTimeInput.Text;
                _currentRace.Destination = destinationInput.Text;
                _currentRace.TicketPrice = ticketPrice;
                _currentRace.TotalSeats = totalSeats;
                _currentRace.TripDescription = tripDescriptionInput.Text;

                _repository.Update(_currentRace);
                MessageBox.Show("Рейс успешно обновлен!");
                _loadRaces?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}