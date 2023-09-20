using ExtractNodeNameSelfClosingTags;

namespace ExtractNodeNameSelfClosingTagsTest
{
    public class NodeNameTest
    {
        [Theory]
        [InlineData("<Descripton/>", "Descripton")]
        [InlineData("<ScanFTP/>", "ScanFTP")]
        [InlineData("<Network/>", "Network")]
        public void ShouldVerifyExtractNodeName(string value, string expected)
        {
            string actual = string.Empty;

            var sut = new ExtractNodeName();
            actual = sut.GetNodeName(value);

            Assert.Equal(expected, actual); 
        }
    }
}