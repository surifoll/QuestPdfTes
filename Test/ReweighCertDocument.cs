using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPdf;

public class ReweighCertDocument : IDocument
{
    private ReweighCertModel Model { get; }

    public ReweighCertDocument(ReweighCertModel invoiceModel)
    {
        Model = invoiceModel;
    }
    /* code omitted */

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;


    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                page.Margin(10);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);


                page.Footer().AlignCenter().Text(x =>
                {
                    x.CurrentPageNumber();
                    x.Span(" / ");
                    x.TotalPages();
                });
            });
    }

    void ComposeHeader(IContainer container)
    {
        var titleStyle = TextStyle.Default.FontSize(17).FontFamily("Sawarabi Mincho").SemiBold();

        container.Row(row =>
        {
            row.RelativeItem()
                .Column(column => { column.Item().Text($"#{Model.ReweighCertNumber}").Style(titleStyle); });
            row.ConstantItem(100).Width(100).Column(column =>
            {
                column.Item().Text(text => { text.Span("||| |||| |||||| |||||").SemiBold(); });
            });
        });
    }


    void ComposeContent(IContainer container)
    {
        container.PaddingVertical(40).Column(column =>
        {
           
            column.Item()
                .AlignCenter()
                .AlignMiddle()
                .Column(col =>
                {
                    col.Item()
                        .Width(230)
                        .AlignCenter()
                        .Text(text =>
                    {
                        text.Span($"{Model.Title}").Bold().FontSize(17);
                        text.EmptyLine();
                        text.Span($"{Model.TitleAddress}").Bold().FontSize(17).WrapAnywhere(false);
                    });
                });
           
            column.Item()
                .Column(col =>
                {
                    col.Item()
                        .Text(text =>
                        {
                            text.Span($"{Model.Company}").SemiBold().FontSize(13);
                            text.EmptyLine();
                            text.Span($"{Model.CompanyAddress}").SemiBold().FontSize(13);
                        });
                });
            column.Item().Text(text =>
            {
                text.EmptyLine();
            });
            column.Item().LineHorizontal(1);
            column.Item()
                .AlignMiddle()
                .AlignCenter()
                .PaddingBottom(5).Text("CODE 4 REWEIGH CERTIFICATE").SemiBold();
            column.Item().LineHorizontal(1);
            
            column.Item().Text(text =>
            {
                text.EmptyLine();
            });
            column.Item()
                .Column(col =>
                {
                    col.Item()
                        .Text(text =>
                        {
                            
                            text.Span($"Name:           {Model.Name}   ").Bold().FontSize(12);
                            text.Span($"SSAN: {Model.Ssan}").Bold().FontSize(12);
                            text.EmptyLine();
                            
                            text.Span($"GBL#:           {Model.Gbl}   ").Bold().FontSize(12);
                            text.Span($"P/U: {Model.Pu}  ").Bold().FontSize(12);
                            text.Span($"DEL: {Model.Del}").Bold().FontSize(12);
                            text.Span($"RDD: {Model.Rdd}").Bold().FontSize(12);
                            text.EmptyLine();  
                            
                            text.Span($"SCAC#:          {Model.Scac}   ").Bold().FontSize(12);
                            text.Span($"AGENT REFERENCE: {Model.AgentReference}  ").Bold().FontSize(12);
                           
                            text.EmptyLine();
                            text.Span($"FROM:           {Model.From}").Bold().FontSize(12);
                           
                            
                            
                        });
                });
            column.Item().Text(text =>
            {
                text.EmptyLine();
            });
            column.Item().LineHorizontal(1);
            //column.Item().Element(ComposeTable);
        });
    }
}