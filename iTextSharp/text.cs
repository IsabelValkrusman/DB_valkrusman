using System;

namespace iTextSharp
{
    internal class text
    {
        internal class Document
        {
            internal void Add(text.Paragraph paragraph)
            {
                throw new NotImplementedException();
            }

            internal void Close()
            {
                throw new NotImplementedException();
            }

            internal void Open()
            {
                throw new NotImplementedException();
            }
        }

        internal class Paragraph
        {
            private string text;

            public Paragraph(string text)
            {
                this.text = text;
            }
        }
    }
}