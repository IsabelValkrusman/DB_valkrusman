using System;
using System.IO;

namespace DB_valkrusman
{
    public class HtmlTextWriter
    {
        private StreamWriter twr;

        public HtmlTextWriter(StreamWriter twr)
        {
            this.twr = twr;
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void Flush()
        {
            throw new NotImplementedException();
        }
    }
}