using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "Новая заметка 1";
            var note = new Note();
            note.Title = expected;
            var actual = note.Title;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильную фамилию");
        }

        [TestCase("Название-Название-Название-Название-Название-Название", 
            "Должно возникать исключение, если название длиннее 50 символов", TestName = "Присвоение Title более 50 символов")]
        [TestCase("", "Должно возникать исключение, если название пустое", TestName = "Присвоение Title пустой строки")]
        public void TestTitleSet_ArgumentExeption(string wrongTitle, string message)
        {
            var note = new Note();
            Assert.Throws<ArgumentException>(
            () => { note.Title = wrongTitle; }, message);            
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = "Текст заметки";
            var note = new Note();
            note.Text = expected;
            var actual = note.Text;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильную фамилию");
        }

        [Test(Description = "Присвоение Text пустой строки")]
        public void TestTextSet_ArgumentExeption()
        {
            var note = new Note();
            Assert.Throws<ArgumentException>(
            () => { note.Title = ""; }, "Присвоение Text пустой строки");
        }


        [Test(Description = "Позитивный тест  Type")]
        public void TestTypeGet_CorrectValue()
        {
            var expected = NoteCategory.Documents;
            var note = new Note();
            note.Category = expected;
            var actual = note.Category;

            Assert.AreEqual(expected, actual, "возвращает неправильный Type");
        }


        [Test(Description = "Позитивный тест  Clone")]
        public void TestClone_CorrectValue()
        {
            var expected = new Note();
            expected.Text = "Text 1";
            expected.Title = "Title 1";
            expected.Category = NoteCategory.Different;
            Note clone = (Note)expected.Clone();
            var actual = clone;
            Assert.AreEqual(expected.Text, actual.Text, "");
            Assert.AreEqual(expected.Title, actual.Title, "");
            Assert.AreEqual(expected.Category, actual.Category, "");
        }

        [Test(Description = "Позитивный тест TimeCreated")]
        public void TestNoteCreatedGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note();
            var actual = note.TimeCreation;
            Assert.AreEqual(dateNow, actual, " TimeCreated возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест  TimeModified")]
        public void TestNoteChangedGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note();
            note.TimeModified = dateNow;
            var actual = note.TimeModified;
            var expected = dateNow;
            Assert.AreEqual(expected, actual, "TimeChanged возвращает неправильное значение");

        }

        [Test(Description = "Дата изменения больше текущей даты")]
        public void TestNoteChangedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note();
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(() => { note.TimeModified = time; }, "Должно возникать исключение");
        }

        [Test(Description = "Дата создания больше текущей дата")]
        public void TestNoteCreatedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note();
            time = time.AddYears(1000);
            Assert.Throws<ArgumentException>(() => { note.TimeCreation = time; }, "Должно возникать исключение");
        }



        [Test(Description = "Дата изменения больше  даты создания")]
        public void TestNoteChangedSet()
        {
            var time = DateTime.Now;
            var note = new Note();
            time = time.AddDays(-100);
            Assert.Throws<ArgumentException>(() => { note.TimeModified = time; }, "Должно возникать исключение");
        }
    }
}
