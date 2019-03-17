using System;
using NUnit.Framework;

namespace AcronymFromPhrase.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("")]
        public void When_EmptyString_Expect_EmptyString(string phrase)
        {
            Assert.That(AcronymFromPhrase.GenerateAcronym(phrase), Is.EqualTo(""));
        }

        [TestCase("Don't repeat yourself")]
        public void When_PhraseDontRepeatYourSelf_Expect_DRY(string phrase)
        {
            Assert.That(AcronymFromPhrase.GenerateAcronym(phrase), Is.EqualTo("DRY"));
        }
        
        [TestCase("Keep it simple stupid")]
        public void When_PhraseKeepItSimpleStupid_Expect_KISS(string phrase)
        {
            Assert.That(AcronymFromPhrase.GenerateAcronym(phrase), Is.EqualTo("KISS"));
        }
        
        [TestCase("Asynchronous Javascript and XML")]
        public void When_PhraseAsynchronousJavascriptAndXml_Expect_AJAX(string phrase)
        {
            Assert.That(AcronymFromPhrase.GenerateAcronym(phrase), Is.EqualTo("AJAX"));
        }
        
        [TestCase("Complementary metal-oxide semiconductor")]
        public void When_PhraseComplementaryMetalOxideSemiconductor_Expect_CMOS(string phrase)
        {
            Assert.That(AcronymFromPhrase.GenerateAcronym(phrase), Is.EqualTo("CMOS"));
        }
        
        
        
        
    }
}