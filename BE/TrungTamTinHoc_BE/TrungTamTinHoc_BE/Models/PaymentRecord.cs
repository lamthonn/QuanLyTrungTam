namespace TrungTamTinHoc_BE.Models
{
    public class PaymentRecord
    {
        public string Id { get; set; }
        public string StripeSessionId { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public string KhoaHocId { get; set; }
    }
}
