using WebASP.Context;
using WebASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebASP.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        WebAPSEntities4 objASPNETEntities = new WebAPSEntities4();
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                // lấy thông tin từ giỏ hàng trong session
                var istCart = (List<CartModel>)Session["cart"];

                // tạo dữ liệu cho Order
                Order objOrder = new Order();
                objOrder.name = "DonHang-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                objOrder.user_id = int.Parse(Session["idUser"].ToString());
                objOrder.created_at = DateTime.Now;
                objOrder.status = 17;

                objASPNETEntities.Orders.Add(objOrder);

                // lưu thông tin vào bảng Order
                objASPNETEntities.SaveChanges();

                // Lấy OrderId vừa tạo để lưu vào bảng OrderDetail
                int orderId = objOrder.id;
                List<OrderDetail> lstOrderDetail = new List<OrderDetail>();

                foreach (var item in istCart)
                {
                    OrderDetail obj = new OrderDetail();
                    obj.quantity = item.Quantity;
                    obj.order_id = orderId;
                    obj.product_id = item.Product.id;
                    lstOrderDetail.Add(obj);
                }

                objASPNETEntities.OrderDetails.AddRange(lstOrderDetail);
                objASPNETEntities.SaveChanges();
            }

            return View();
        }
    }
}