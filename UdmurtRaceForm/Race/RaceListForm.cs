using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class RaceListForm : Form
    {
        private readonly IRaceRepository _repository;

        public RaceListForm(IRaceRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            LoadRaces();
            RenameColumnsNames();
        }

        private void RenameColumnsNames()
        {
            dataGridViewRaces.Columns[0].HeaderText = "ID";
            dataGridViewRaces.Columns[1].HeaderText = "Номер рейса";
            dataGridViewRaces.Columns[2].HeaderText = "Дата отправления";
            dataGridViewRaces.Columns[3].HeaderText = "Время отправления";
            dataGridViewRaces.Columns[4].HeaderText = "Пункт назначения";
            dataGridViewRaces.Columns[5].HeaderText = "Цена билета";
            dataGridViewRaces.Columns[6].HeaderText = "Общее количество мест";
            dataGridViewRaces.Columns[7].HeaderText = "Описание рейса";

            dataGridViewRaces.Columns["RaceId"].Visible = true;
        }

        private void LoadRaces()
        {
            var races = _repository.GetAll();
            dataGridViewRaces.DataSource = null;
            dataGridViewRaces.DataSource = races;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadRaces();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddRaceForm form = new AddRaceForm(_repository, LoadRaces);
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewRaces.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для обновления.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewRaces.SelectedRows[0];
            var raceId = selectedRow.Cells["RaceId"].Value;

            if (raceId == null || !int.TryParse(raceId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор рейса.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var race = _repository.GetById(id);
                if (race == null)
                {
                    MessageBox.Show("Рейс не найден.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateRaceForm form = new UpdateRaceForm(_repository, race, LoadRaces);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewRaces.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для удаления.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewRaces.SelectedRows[0];
            var raceId = selectedRow.Cells["RaceId"].Value;

            if (raceId == null || !int.TryParse(raceId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор рейса.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _repository.Delete(id);
                LoadRaces();
                MessageBox.Show("Рейс успешно удалён.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewRaces.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}