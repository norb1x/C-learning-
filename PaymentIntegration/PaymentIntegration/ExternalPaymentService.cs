// Interfejs niekompatybilnego systemu płatności
public interface IExternalPaymentService
{
    ExternalPaymentResult ExecuteTransaction(ExternalPaymentRequest request);
}

public class ExternalPaymentRequest
{
    public int AmountCents { get; set; }
    public string EncryptedCardData { get; set; }
    public string MerchantId { get; set; }
}

public class ExternalPaymentResult
{
    public bool Success { get; set; }
    public string TransactionId { get; set; }
    public string ErrorCode { get; set; }
}

// Mock implementacji zewnętrznego systemu
public class ExternalPaymentService : IExternalPaymentService
{
    public ExternalPaymentResult ExecuteTransaction(ExternalPaymentRequest request)
    {
        // Symulacja komunikacji z API
        return new ExternalPaymentResult
        {
            Success = request.AmountCents > 0,
            TransactionId = Guid.NewGuid().ToString(),
            ErrorCode = request.AmountCents <= 0 ? "INVALID_AMOUNT" : null
        };
    }
}
