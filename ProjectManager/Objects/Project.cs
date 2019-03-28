using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Project
    {
        private int _id;
        private string _name;
        private List<Note> _notes;
        private List<ToDo> _todos;
        private List<Meeting> _meetings;
        private int _notesCount;
        private int _todosCount;
        private int _meetingsCount;

        public int ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Note> Notes { get => _notes; set => _notes = value; }
        public List<ToDo> Todos { get => _todos; set => _todos = value; }
        public List<Meeting> Meetings { get => _meetings; set => _meetings = value; }
        public int NotesCount { get => _notesCount; }
        public int TodosCount { get => _todosCount; }
        public int MeetingsCount { get => _meetingsCount; }

        public Project(string name = "")
        {
            Name = name;
            Notes = new List<Note>();
            Todos = new List<ToDo>();
            Meetings = new List<Meeting>();
        }

        private void GetLists(List<Note> notes, List<ToDo> todos, List<Meeting> meetings)
        {
            Notes = notes;
            Todos = todos;
            Meetings = meetings;
        }

        private void Count()
        {
            _notesCount = Notes.Count();
            _todosCount = Todos.Count();
            _meetingsCount = Meetings.Count();
        }

        private void AddNote(Note note)
        {
            Notes.Add(note);
        }

        private void AddToDo(ToDo todo)
        {
            Todos.Add(todo);
        }

        private void AddMeeting(Meeting meeting)
        {
            Meetings.Add(meeting);
        }
    }
}
