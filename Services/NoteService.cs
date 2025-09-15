using Blazored.LocalStorage;
using MiDiarioApp.Models;

namespace MiDiarioApp.Services
{
    public class NoteService
    {
        private readonly ILocalStorageService _localStorage;
        private const string Key = "notes";

        public NoteService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            return await _localStorage.GetItemAsync<List<Note>>(Key) ?? new List<Note>();
        }

        public async Task SaveNoteAsync(Note note)
        {
            var notes = await GetNotesAsync();
            notes.Add(note);
            await _localStorage.SetItemAsync(Key, notes);
        }
    }
}