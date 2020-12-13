using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            int x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }


        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        [Fact]
        public void StringsBehaveLikeValueType()
        {
            string name = "Scott";
            string upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }
        [Fact]
        public void AddGradeTest()
        {
            Book book = GetBook("Luis");
            book.AddGrade(-60);
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }

}
