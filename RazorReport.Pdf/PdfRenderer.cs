using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml;
using iTextSharp.text.pdf;

namespace RazorReport.Pdf {
    public class PdfRenderer : ICustomRenderer {
        public byte[] RenderFromHtml (string html) {
            var output = new MemoryStream ();
            using (var reader = new StringReader (html)) {

                var document = new Document ();
                var writer = PdfWriter.GetInstance(document, output);
                writer.SetTagged();

                document.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, reader);
                document.Close();

                return output.ToArray ();
            }
        }
    }
}
