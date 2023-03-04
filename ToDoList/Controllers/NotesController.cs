using Microsoft.AspNetCore.Mvc;
using ToDoList.DataBase.Entity;
using ToDoList.Interfaces;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class NotesController : ControllerBase
        {
            private INotesService _service;

            public NotesController(INotesService service)
            {
                _service = service;
            }
            [HttpGet]
            public async Task<ActionResult<List<Note>>> GetAllNotes()
            {
                var note = await _service.GetAllNotes();
                return Ok(note);

            }
        [HttpPut]
        public async Task<ActionResult<Note>> EditNoteById(int ID)
        {
            var editnote = await _service.EditNoteById(ID);
            return Ok(editnote);
        }
        [HttpPost]
        public async Task<IActionResult> AddNote(Note note)
        {
            var AddNewNote = await _service.AddNote(note);
            return Ok(AddNewNote);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteNote(int ID)
        {
            var deletenote = await _service.DeleteNote(ID);
            return Ok(deletenote);
        }
    }
}
