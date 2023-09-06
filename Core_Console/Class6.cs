using System.Text;

namespace MyNamespace
{

    public class XDataView
    {
        private A _idDict = new A();

        public void View()
        {
            StringBuilder sbInfo = new StringBuilder();
            ExploreDictionary( sbInfo);
        }

        /// <summary>
        /// Make this method static.
        /// </summary>
        private void ExploreDictionary( StringBuilder sbInfo, string tab = "    ")
        {
            var entry = _idDict.GetObject();
        }

    }

    internal class A
    {
        public object GetObject()
        {
            throw new NotImplementedException();
        }
    }
}