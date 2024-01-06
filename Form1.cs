using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PA_Proiect
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\filim\\source\\repos\\PA Proiect\\Database1.mdf\";Integrated Security=True";

        SqlDataAdapter adapter;
        private DataSet dataSet;

        SqlDataAdapter clientAdapter;
        private DataSet clientDataSet;

        private void showProductsData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Defineți comanda SQL pentru a selecta datele din tabela Produs
                string query = "SELECT IDProdus, Nume, Pret FROM Produs";
                SqlCommand command = new SqlCommand(query, connection);

                // Creați un adaptor de date și umpleți un DataSet cu datele
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Produs");

                // Setați sursa de date pentru DataGridView
                dataGridView1.DataSource = dataSet.Tables["Produs"];
            }
        }

        private void showClientData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Defineți comanda SQL pentru a selecta datele din tabela Produs
                string query = "SELECT * FROM Client";
                SqlCommand command = new SqlCommand(query, connection);

                // Creați un adaptor de date și umpleți un DataSet cu datele
                clientAdapter = new SqlDataAdapter(command);
                clientDataSet = new DataSet();
                clientAdapter.Fill(clientDataSet, "Client");

                // Setați sursa de date pentru DataGridView
                dataGridView2.DataSource = clientDataSet.Tables["Client"];
            }
        }

        public Form1()
        {
            InitializeComponent();
            showProductsData();
            showClientData();
        }

        private void AdaugaProdusInBazaDeDate(string numeProdus, decimal pretProdus)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Defineți comanda SQL pentru a adăuga un produs
                string query = "INSERT INTO Produs (Nume, Pret) VALUES (@Nume, @Pret)";
                SqlCommand command = new SqlCommand(query, connection);

                // Adăugați parametrii pentru a evita SQL Injection
                command.Parameters.AddWithValue("@Nume", numeProdus);
                command.Parameters.AddWithValue("@Pret", pretProdus);

                // Executați comanda
                command.ExecuteNonQuery();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            // Obțineți valorile din TextBox-urile de nume și preț
            string numeProdus = txtNumeProdus.Text;
            decimal pretProdus;

            if (decimal.TryParse(txtPretProdus.Text, out pretProdus))
            {
                // Adăugare produs în baza de date
                AdaugaProdusInBazaDeDate(numeProdus, pretProdus);
            }
            else
            {
                MessageBox.Show("Introduceți un preț valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showProductsData();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Defineți comanda SQL pentru a adăuga un produs
                    string query = "DELETE FROM PRODUS WHERE IDProdus=@Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Adăugați parametrii pentru a evita SQL Injection
                    command.Parameters.AddWithValue("@Id", item.Cells[0].Value.ToString());

                    // Executați comanda
                    command.ExecuteNonQuery();
                }

                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void UpdateDatabase(object id, string columnName, object updatedValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Construct your SQL update command
                string updateQuery = $"UPDATE Produs SET {columnName} = @UpdatedValue WHERE IDProdus = @Id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    command.Parameters.AddWithValue("@Id", id);

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Access values in the row
                object productId = row.Cells["IDProdus"].Value; // Replace with the actual column name
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                Console.WriteLine(columnName);


                // Get the updated value
                object updatedValue = cell.Value;

                // Use the updated value as needed
                Console.WriteLine($"Updated Value: {updatedValue}");
                UpdateDatabase(productId, columnName, updatedValue);

            }

            // Refresh the DataTable and DataGridView
            showProductsData();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Defineți comanda SQL pentru a adăuga un produs
                    string query = "DELETE FROM Client WHERE IDClient=@Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Adăugați parametrii pentru a evita SQL Injection
                    command.Parameters.AddWithValue("@Id", item.Cells[0].Value.ToString());

                    // Executați comanda
                    command.ExecuteNonQuery();
                }
             
                dataGridView2.Rows.RemoveAt(item.Index);
            }
        }

        private void AddClientInDb(string name, string email)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Defineți comanda SQL pentru a adăuga un produs
                string query = "INSERT INTO Client (Nume, Email) VALUES (@Name, @Email)";
                SqlCommand command = new SqlCommand(query, connection);

                // Adăugați parametrii pentru a evita SQL Injection
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);

                // Executați comanda
                command.ExecuteNonQuery();
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            // Obțineți valorile din TextBox-urile de nume și preț
            string clientName = clientNameTb.Text;
            string clientEmail = clientEmailTb.Text;

            // Adăugare produs în baza de date
            AddClientInDb(clientName, clientEmail);
            showClientData();
        }

        private void UpdateClientDatabase(object id, string columnName, object updatedValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Construct your SQL update command
                string updateQuery = $"UPDATE Client SET {columnName} = @UpdatedValue WHERE IDClient = @Id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    command.Parameters.AddWithValue("@Id", id);

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Access values in the row
                object clientId = row.Cells["IDClient"].Value; // Replace with the actual column name
                string columnName = dataGridView2.Columns[e.ColumnIndex].Name;

                // Get the updated value
                object updatedValue = cell.Value;

                // Use the updated value as needed
                Console.WriteLine($"Updated Value: {updatedValue}");
                UpdateClientDatabase(clientId, columnName, updatedValue);

            }

            // Refresh the DataTable and DataGridView
            showProductsData();
        }

    }

}