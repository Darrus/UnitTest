using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Count_StackNotEmpty_ReturnCountOfStack()
        {
            _stack.Push("a");
            _stack.Push("b");

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowArgumentNull()
        {
            Assert.That(() => { _stack.Push(null); }, Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArgument_AddArgumentToStack()
        {
            _stack.Push("a");
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_StackIsEmpty_ThrowInvalidOperation()
        {
            Assert.That(() => { _stack.Pop(); }, Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackIsNotEmpty_RemoveObjectFromTopOfStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackIsEmpty_ThrowInvalidOperation()
        {
            Assert.That(() => { _stack.Peek(); }, Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_GetHighestElement_ReturnHighestElement()
        {
            _stack.Push("Hello");
            _stack.Push("World");
            _stack.Push("!");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("!"));
        }
    }
}
