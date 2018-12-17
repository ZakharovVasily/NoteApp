using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test(Description = "Проверка сохранения и открытия файла")]
        public void TestProjectManagerSaveToFile()
        {
            var fileForSavePath = @"E:\Test.txt";
            var note = new Note();

            note.Title = "Title";
            note.Text = "Text";
            note.TimeModified = DateTime.Now;
            note.TimeCreation = DateTime.Now;
            note.Category = NoteCategory.Different;

            var project = new Project();
            project.Notes.Add(note);

            ProjectManager.SaveProject(project, fileForSavePath);
            var actual = ProjectManager.OpenProject(fileForSavePath);

            Assert.AreEqual(project.Notes.Count, actual.Notes.Count, "");
            Assert.AreEqual(project.Notes[0].Title, actual.Notes[0].Title, "");
            Assert.AreEqual(project.Notes[0].Text, actual.Notes[0].Text, "");
            Assert.AreEqual(project.Notes[0].TimeModified, actual.Notes[0].TimeModified, "");
            Assert.AreEqual(project.Notes[0].TimeCreation, actual.Notes[0].TimeCreation, "");
            Assert.AreEqual(project.Notes[0].Category, actual.Notes[0].Category, "");
        }

        [Test(Description = "Проверка открытия несуществующего файла")]
        public void TestProjectManagerOpenToNotFile()
        {
            var actual = ProjectManager.OpenProject("aaa.txt");

            Assert.AreEqual(null, actual, "Файл не найден");
        }
    }
}
