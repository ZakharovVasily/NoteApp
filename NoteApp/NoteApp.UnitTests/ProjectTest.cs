using System;
using System.Collections.Generic;
using  NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Проверка добавления заметки в Project")]
        public void TestAddNoteToProject()
        {
            var note = new Note();
            note.Title = "Title";
            note.Text = "Text";
            note.TimeModified = DateTime.Now;
            note.TimeCreation = DateTime.Now;
            note.Category = NoteCategory.Different;

            var project = new Project();
            project.Notes.Add(note);
            var actual = project.Notes;
            Assert.AreEqual(project.Notes, actual, "");
        }

        [Test(Description = "Проверка списка заметок в Project")]
        public void TestListNoteToProject()
        {
            var notes = new List<Note>
            {
                new Note {Title = "Title 1"},
                new Note {Title = "Title 2"},
                new Note {Title = "Title 3"}
            };
            
            var project = new Project(notes);
            Assert.AreEqual(project.Notes, notes, "");
        }
    }
}
