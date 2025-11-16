using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class AddRaceForm : Form
    {
        private readonly IRaceRepository _repository;
        private Action _loadRaces;

        public AddRaceForm(IRaceRepository repository, Action loadRaces)
        {
            InitializeComponent();
            _repository = repository;
            _loadRaces = loadRaces;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tripNumberInput.Text) ||
                string.IsNullOrWhiteSpace(departureDateInput.Text) ||
                string.IsNullOrWhiteSpace(departureTimeInput.Text) ||
                string.IsNullOrWhiteSpace(destinationInput.Text))
            {
                MessageBox.Show("Номер рейса, дата, время и пункт назначения не должны быть пустыми.",
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
                var race = new RaceEntity
                {
                    TripNumber = tripNumberInput.Text,
                    DepartureDate = departureDateInput.Text,
                    DepartureTime = departureTimeInput.Text,
                    Destination = destinationInput.Text,
                    TicketPrice = ticketPrice,
                    TotalSeats = totalSeats,
                    TripDescription = tripDescriptionInput.Text
                };

                _repository.Add(race);
                MessageBox.Show("Рейс успешно добавлен!");
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