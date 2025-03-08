class Program
{
    static void Main()
    {
        var externalService = new ExternalPaymentService();
        IPaymentAdapter adapter = new PaymentAdapter(externalService);

        var paymentDetails = new PaymentDetails
        {
            Amount = 150.99m,
            CardNumber = "1234 5678 9012 3456",
            CVV = "123",
            ExpiryDate = "12/25"
        };

        bool result = adapter.ProcessPayment(paymentDetails);

        Console.WriteLine(result 
            ? "Płatność została przetworzona pomyślnie." 
            : "Wystąpił problem podczas przetwarzania płatności.");
    }
}
