using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NoteApp;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace NoteAppUT
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
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
    }
}
