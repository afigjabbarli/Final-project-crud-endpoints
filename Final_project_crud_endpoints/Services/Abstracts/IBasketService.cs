using Final_project_crud_endpoints.DataBase.DTOs.Basket;
using Final_project_crud_endpoints.DataBase.Entities;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IBasketService
    {
        BasketItem AppendProductToBasket(BasketCookieItem basket_cookie_item);
        List<BasketListItemDTO> FetchAllBasketItems();
        void ClearBasketItems();
    }
}
