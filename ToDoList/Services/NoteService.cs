using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ToDoList.DataBase.Context;
using ToDoList.DataBase.Entity;
using ToDoList.Interfaces;

namespace ToDoList.Services
{
    public class NoteService : INotesService
    {
        private readonly NoteDBContext dbContext;
        private readonly IConfiguration _configuration;
        public Task<Note> AddNote(Note note)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("AltaGeSales").ToString());
            note.CreatedDate = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INRO Notes(Body,DateCreated) VALUES('" + note.Body + "','" + note.CreatedDate + "", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            throw new NotImplementedException();


        }

        public Task<Note> DeleteNote(int ID)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("AltaGeSales").ToString());
            SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE ID=('" + ID + "", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            throw new NotImplementedException();
        }

        public Task<Note> EditNoteById(int ID,Note note)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("AltaGeSales").ToString());
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET Body =('" + note.Body + "') WHERE ID =('" + ID + "')", con);
            con.Open();
            throw new NotImplementedException();
        }

        public async Task<List<Note>> GetAllNotes()
        {
            return await dbContext.NoteList.ToListAsync();
        }
    }
}
