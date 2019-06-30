using FluentAssertions;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class LinkedListTest
    {
        [Fact]
        public void Insert_Empty()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Items.Should().Equal(1);
        }

        [Fact]
        public void Insert_123()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(2);
            ll.Insert(3);
            ll.Items.Should().Equal(3, 2, 1);
        }

        [Fact]
        public void Reverse_123()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(2);
            ll.Insert(3);
            ll.Reverse().Items.Should().Equal(1, 2, 3);
        }

        [Fact]
        public void Insert_111()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(1);
            ll.Insert(1);
            ll.Items.Should().Equal(1, 1, 1);
        }

        [Fact]
        public void Remove_All_1()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(1);
            ll.Insert(1);
            ll.Remove(1);
            ll.Items.Should().BeEmpty();
        }

        [Fact]
        public void Remove_Head()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(2);
            ll.Insert(3);
            ll.Remove(3);
            ll.Items.Should().Equal(2, 1);
        }

        [Fact]
        public void Remove_1()
        {
            var ll = new LinkedList<int>();
            ll.Insert(1);
            ll.Insert(2);
            ll.Insert(3);
            ll.Remove(1);
            ll.Items.Should().Equal(3, 2);
        }
    }
}
