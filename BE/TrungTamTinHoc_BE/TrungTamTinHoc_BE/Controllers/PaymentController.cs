using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrungTamTinHoc_BE.Data;
using TrungTamTinHoc_BE.Models;
using TrungTamTinHoc_BE.Services;

namespace TrungTamTinHoc_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly StripePaymentService _paymentService;
        private readonly AppDbContext _context;

        public PaymentController(StripePaymentService paymentService, AppDbContext context)
        {
            _paymentService = paymentService;
            _context = context;
        }

        [HttpPost("create-checkout-session")]
        public ActionResult CreateCheckoutSession(PaymentParam param)
        {
            try
            {
                var session = _paymentService.CreateCheckoutSession(param);

                // Record the session in your DB
                _context.paymentRecords.Add(new PaymentRecord
                {
                    Id = Guid.NewGuid().ToString(),
                    StripeSessionId = session.Id,
                    Created = DateTime.UtcNow,
                    Status = "Created",
                    UserId = param.userId!,
                    KhoaHocId = param.khoahocId!

                });
                _context.SaveChanges();



                return Ok(new { sessionId = session.Id });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpPost("success")]
        public async Task<IActionResult> Success([FromBody] string sessionId, string userId)
        {
            var paymentRecord = await _context.paymentRecords.FirstOrDefaultAsync(p => p.StripeSessionId == sessionId);
            if (paymentRecord != null)
            {
                //chuyển đổi phân quyền sau khi thanh toán
                //var userPay = _context.UserRoles.FirstOrDefault(x => x.UserId == userId);
                //if (userPay != null)
                //{
                //    userPay.RoleId = 4;
                //}
                //_context.UserRoles.Update(userPay);
                //_context.SaveChanges();

                paymentRecord.Status = "Success";
                await _context.SaveChangesAsync();
            }

            // Redirect to a success page or return success response
            return Ok("Payment successful.");
        }

    }
}
