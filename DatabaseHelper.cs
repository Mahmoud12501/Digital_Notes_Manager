using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DatabaseHelper
{
    private string connectionString = ConfigurationManager.ConnectionStrings["NotesDb"].ConnectionString;

    ///login
    public bool ValidateUser(string email, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password); // لاحقًا نستخدم hashing

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }

    public int GetUserIdByEmail(string email)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT UserID FROM Users WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            conn.Open();
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : -1;
        }
    }

    ////////////// regster
    public bool IsEmailExist(string email)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }

    public void RegisterUser(string email, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Email, Password) VALUES (@Email, @Password)", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
    //delet note
    public void DeleteNote(int noteId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE NoteID = @NoteID", conn);
            cmd.Parameters.AddWithValue("@NoteID", noteId);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }


    //retrive all notes
    public DataTable GetNotesByUser(int userId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT NoteID, Title, Category, CreatedDate, ReminderDate FROM Notes WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    // add note
    public void AddNote(string title, string content, string category, DateTime createdDate, DateTime reminderDate, int userId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Notes (Title, Content, Category, CreatedDate, ReminderDate, UserID) VALUES (@Title, @Content, @Category, @CreatedDate, @ReminderDate, @UserID)", conn);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Content", content);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@ReminderDate", reminderDate);
            cmd.Parameters.AddWithValue("@UserID", userId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    ///load notes
    public DataRow GetNoteById(int noteId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Notes WHERE NoteID = @NoteID", conn);
            cmd.Parameters.AddWithValue("@NoteID", noteId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }
    }
    ///update
    public void UpdateNote(int noteId, string title, string content, string category, DateTime reminderDate)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("UPDATE Notes SET Title = @Title, Content = @Content, Category = @Category, ReminderDate = @ReminderDate WHERE NoteID = @NoteID", conn);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Content", content);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@ReminderDate", reminderDate);
            cmd.Parameters.AddWithValue("@NoteID", noteId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }


    // لاحقًا: دوال GetNotesByUserId, AddNote, UpdateNote, DeleteNote
}
