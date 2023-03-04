using ToDoList.DataBase.Entity;

namespace ToDoList.Interfaces
{
    public interface INotesService
    {
        Task<List<Note>> GetAllNotes();
        Task<Note> EditNoteById(int ID, Note note);
        Task<Note> AddNote(Note note);
        Task<Note> DeleteNote(int ID);
    }
}
