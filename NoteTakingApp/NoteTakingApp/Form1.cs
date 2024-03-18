using Microsoft.Data.SqlClient;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            savedNotes form2 = new savedNotes();
            form2.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string noteTitle = title.Text;
            string noteContent = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(noteTitle) || string.IsNullOrWhiteSpace(noteContent))
            {
                MessageBox.Show("Please enter a title and content for the note.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=MDNoteDB; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp)";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@Title", noteTitle);
                    command.Parameters.AddWithValue("@Content", noteContent);
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note saved successfully.");
                        title.Clear();
                        richTextBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save note.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}