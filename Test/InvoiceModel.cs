namespace QuestPdf;

public class InvoiceModel
{
    public int InvoiceNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }

    public Address SellerAddress { get; set; }
    public Address CustomerAddress { get; set; }

    public List<OrderItem> Items { get; set; }
    public string Comments { get; set; }
}
public class OrderModel
{
    public int OrderNumber { get; set; }
    public DateTimeOffset PaymentDate { get; set; }
    public Address VendorAddress { get; set; }
    public List<OrderItem> Items { get; set; }
    public string Comments { get; set; }
    public DateTimeOffset OrderDate { get; set; }
}
public class ReweighCertModel
{
    public string ReweighCertNumber { get; set; } = "REWEIGHCER_I_E123454346";
    public string Title { get; set; } = "GOSSELIN MOBILITY NV";
    public string TitleAddress { get; set; } = "BELCROWNLAAN 23 BELGIUM";
    public string Company { get; set; } = "ABLE MOVING AND STORAGE";
    public string CompanyAddress { get; set; } = "UNITED STATE";
    public string Name { get; set; } = "CIV WELCH DENISE";
    public string Ssan { get; set; } = "--";
    public string Gbl { get; set; } = "EL22708874";
    public string Pu { get; set; } = "25AUG22";
    public string Del { get; set; } = "09NO0V22";
    public string Rdd { get; set; }
    public string Scac { get; set; } = "AMJV";
    public string AgentReference { get; set; }
    public string From { get; set; } = "UWDK CY";
    public int Pieces { get; set; }
    public int Gross { get; set; }
    public int Tare { get; set; }
    public int Net { get; set; }
    public int Cbft { get; set; }
    public decimal Density { get; set; }
}

public class OrderItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Address
{
    public string CompanyName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public object Email { get; set; }
    public string Phone { get; set; }
}