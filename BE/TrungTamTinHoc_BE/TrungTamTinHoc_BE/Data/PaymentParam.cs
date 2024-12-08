namespace TrungTamTinHoc_BE.Data
{
    public class PaymentParam
    {
        public string? successUrl { get; set; }
        public string? cancelUrl{ get; set; }
        public long? priceInCents { get; set; }
        public string? productName { get; set; }
        public string? userId { get; set; }
        public string? khoahocId { get; set; }
    }
}
