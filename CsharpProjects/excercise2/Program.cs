string[] orderId = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string orderIdItem in orderId)
{
    if (orderIdItem.StartsWith("B"))
{
    Console.WriteLine($"{orderIdItem}starts with 'B'!");
}
}