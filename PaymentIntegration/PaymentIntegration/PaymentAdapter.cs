public class PaymentAdapter : IPaymentAdapter
{
    private readonly IExternalPaymentService _externalService;
    private const string MERCHANT_ID = "BANK_12345";

    public PaymentAdapter(IExternalPaymentService externalService)
    {
        _externalService = externalService;
    }

    public bool ProcessPayment(PaymentDetails paymentDetails)
    {
        try
        {
            // Transformacja danych do formatu zewnętrznego systemu
            var externalRequest = new ExternalPaymentRequest
            {
                AmountCents = ConvertToCents(paymentDetails.Amount),
                EncryptedCardData = EncryptCardData(paymentDetails),
                MerchantId = MERCHANT_ID
            };

            // Wywołanie zewnętrznego systemu
            var result = _externalService.ExecuteTransaction(externalRequest);

            // Transformacja odpowiedzi
            return InterpretResult(result);
        }
        catch (Exception ex)
        {
            LogError(ex);
            return false;
        }
    }

    private int ConvertToCents(decimal amount)
    {
        return (int)(amount * 100);
    }

    private string EncryptCardData(PaymentDetails details)
    {
        // Symulacja procesu szyfrowania
        return $"{details.CardNumber}|{details.ExpiryDate}|{details.CVV}".Trim().Replace(" ", "");
    }

    private bool InterpretResult(ExternalPaymentResult result)
    {
        if (!result.Success)
        {
            LogError($"Błąd płatności: {result.ErrorCode}");
            return false;
        }
        
        LogTransaction(result.TransactionId);
        return true;
    }

    private void LogTransaction(string transactionId)
    {
        Console.WriteLine($"Zarejestrowano transakcję: {transactionId}");
    }

    private void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
    }

    private void LogError(Exception ex)
    {
        Console.WriteLine($"[CRITICAL] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {ex.Message}");
    }
}
