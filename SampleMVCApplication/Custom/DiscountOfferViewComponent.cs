using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApplication.Custom
{
    public class DiscountOfferViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(decimal price)
        {
            if (price > 3000)
            {
                decimal discount = price * 15 / 100;
                decimal finalprice = price - discount;

                return View("_DiscountOffer", finalprice);

            }
            return View("_NoOffer");
        }
    }
}
