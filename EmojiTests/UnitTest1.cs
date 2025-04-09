using NUnit.Framework;
using EmojiTranslatorSimple;

namespace EmojiTests
{
    public class Tests
    {
        private Utils _utils;

        [SetUp]
        public void Setup()
        {
            _utils = new Utils();
            _utils.CreateEmojis();
        }

        [Test]
        public void TranslateEmoji_KnownWord_ReturnsCorrectEmoji()
        {
            string result = _utils.TranslateEmoji("happy");
            Assert.AreEqual("😄", result);
        }

        [Test]
        public void TranslateEmoji_KnownWordWithUpperCase_ReturnsCorrectEmoji()
        {
            string result = _utils.TranslateEmoji("Happy");
            Assert.AreEqual("😄", result);
        }

        [Test]
        public void TranslateEmoji_UnknownWord_ReturnsNull()
        {
            string result = _utils.TranslateEmoji("unknown");
            Assert.IsNull(result);
        }

        [Test]
        public void TranslateEmoji_SpecialEntryChickenJockey_ReturnsCorrectSequence()
        {
            string result = _utils.TranslateEmoji("chicken jockey");
            Assert.AreEqual("👶🐔🧟", result);
        }

        [Test]
        public void OutputEmojis_DoesNotThrow()
        {
            // We are just testing that it executes without exceptions.
            Assert.DoesNotThrow(() => _utils.OutputEmojis());
        }
    }
}