namespace LinQ_Session1;

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public Order[] Orders { get; set; }

    public override string ToString() => $"{CustomerID} {CompanyName}\n{Address} {City} {Region} {PostalCode} {Country}\nPhone: {Phone}";
}

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }

    public override string ToString() => $"OrderID={OrderID}, Date={OrderDate:yyyy-MM-dd}, Total={Total:C}";
}