using QuestPdf;
using QuestPDF.Fluent;
using QuestPDF.Previewer;

// code in your main method
var filePath = "invoice.pdf";

// var model = InvoiceDocumentDataSource.GetInvoiceDetails();
var model = OrderDocumentDataSource.GetOrderDetails();
var document = new OrderReceiptDocument(model);
 document.GeneratePdf(filePath);
//  
//
// // use the following invocation
 document.ShowInPreviewer();
//
// // optionally, you can specify an HTTP port to communicate with the previewer host (default is 12500)
// document.ShowInPreviewer(12345);