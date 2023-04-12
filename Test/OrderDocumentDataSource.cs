using QuestPDF.Helpers;

namespace QuestPdf;

public static class OrderDocumentDataSource
{
    private static Random Random = new Random();

    public static OrderModel GetOrderDetails()
    {
        var items = Enumerable
            .Range(1, 8)
            .Select(i => GenerateRandomOrderItem())
            .ToList();

        return new OrderModel
        {
            OrderNumber = Random.Next(1_000, 10_000),
            OrderDate = DateTime.Now,
            PaymentDate = DateTime.Now + TimeSpan.FromDays(14),
            VendorAddress = GenerateRandomAddress(),
            Items = items,
            Comments = Placeholders.Paragraph()
        };
    }

    private static OrderItem GenerateRandomOrderItem()
    {
        return new OrderItem
        {
            Name = Placeholders.Label(),
            Price = (decimal) Math.Round(Random.NextDouble() * 100, 2),
            Quantity = Random.Next(1, 10)
        };
    }

    private static Address GenerateRandomAddress()
    {
        return new Address
        {
            CompanyName = Placeholders.Name(),
            Street = Placeholders.Label(),
            City = Placeholders.Label(),
            State = Placeholders.Label(),
            Email = Placeholders.Email(),
            Phone = Placeholders.PhoneNumber()
        };
    }
}