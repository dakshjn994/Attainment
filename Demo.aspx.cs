using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
public partial class Demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void ExportToPdf()
    {
        Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        string pdfFilePath = Server.MapPath(".") + "/Bin";
        PdfWriter writer = PdfAWriter.GetInstance(doc, new FileStream(pdfFilePath + "/Default.pdf", FileMode.Create));
        doc.Open();
        try
        {
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 30);
            Paragraph paragraph = new Paragraph("Getting Started ITextSharp.",font5);
            paragraph.Alignment = Element.ALIGN_CENTER;
            font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);
            Paragraph parag = new Paragraph("Getting Started ITextSharp.", font5);
            string imageURL = Server.MapPath(".") + "/images/text1.png";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            //Resize image depend upon your need
            jpg.ScaleToFit(500f, 500f);
            //Give space before image
            jpg.SpacingBefore = 10f;
            //Give some space after the image
            jpg.SpacingAfter = 1f;
            jpg.Alignment = Element.ALIGN_LEFT;

            doc.Add(paragraph);
            doc.Add(jpg);
            doc.Add(parag);
            doc.Close();
        }
        catch(Exception i)
        {
            Response.Write(i.Message);
        }
    }
    public void Abc()
    {
        FileStream fs = new FileStream((string)(Server.MapPath(".")+"Chapter1_Example1.pdf"), FileMode.Create, FileAccess.Write, FileShare.None);
        Document doc = new Document(PageSize.A4);
        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
        doc.Open();
        Paragraph para = new Paragraph("Hello World");
        para.Alignment = Element.ALIGN_CENTER;
        doc.Add(para);
        doc.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Abc();
    }
}