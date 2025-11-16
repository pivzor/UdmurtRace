using System;
using System.Windows.Forms;
using UdmurtRace.DAL.Entities;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    public partial class ClientListForm : Form
    {
        private readonly IClientRepository _repository;

        public ClientListForm(IClientRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            LoadClients();
            RenameColumnsNames();
        }

        private void RenameColumnsNames()
        {
            dataGridViewClients.Columns[0].HeaderText = "ID";
            dataGridViewClients.Columns[1].HeaderText = "Фамилия";
            dataGridViewClients.Columns[2].HeaderText = "Имя";
            dataGridViewClients.Columns[3].HeaderText = "Отчество";
            dataGridViewClients.Columns[4].HeaderText = "Электронная почта";
            dataGridViewClients.Columns[5].HeaderText = "Телефон";
            dataGridViewClients.Columns[6].HeaderText = "Адрес";

            dataGridViewClients.Columns["ClientId"].Visible = true;
        }

        private void LoadClients()
        {
            var clients = _repository.GetAll();
            dataGridViewClients.DataSource = null;
            dataGridViewClients.DataSource = clients;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm(_repository, LoadClients);
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для обновления.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewClients.SelectedRows[0];
            var clientId = selectedRow.Cells["ClientId"].Value;

            if (clientId == null || !int.TryParse(clientId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор клиента.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var client = _repository.GetById(id);
                if (client == null)
                {
                    MessageBox.Show("Клиент не найден.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateClientForm form = new UpdateClientForm(_repository, client, LoadClients);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку для удаления.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewClients.SelectedRows[0];
            var clientId = selectedRow.Cells["ClientId"].Value;

            if (clientId == null || !int.TryParse(clientId.ToString(), out int id))
            {
                MessageBox.Show("Некорректный идентификатор клиента.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _repository.Delete(id);
                LoadClients();
                MessageBox.Show("Клиент успешно удалён.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}