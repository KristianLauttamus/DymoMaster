namespace DymoMaster3000
{
    public class DymoSticker
    {
        public string firstLine = "";
        public string secondLine = "";

        public DymoSticker(string firstLine)
        {
            this.firstLine = firstLine;
        }

        public DymoSticker(string firstLine, string secondLine)
        {
            this.firstLine = firstLine;
            this.secondLine = secondLine;
        }

        public string toString
        {
            get
            {
                if (secondLine.Length > 0)
                {
                    return firstLine + "\n" + secondLine;
                }

                return firstLine;
            }
        }
    }
}