using SweetShopService.Attributies;
using SweetShopService.BindingModels;
using SweetShopService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShopService.Interfaces
{
    [CustomInterface("Интерфейс для работы с заказами")]
    public interface IMainService
    {
        [CustomMethod("Метод получения списка заказов")]
        List<RequestViewModel> GetList();

        [CustomMethod("Метод создания заказа")]
        void CreateRequest(RequestBindingModel model);

        [CustomMethod("Метод передачи заказа в работу")]
        void TakeRequestInWork(RequestBindingModel model);

        [CustomMethod("Метод передачи заказа на оплату")]
        void FinishRequest(int id);

        [CustomMethod("Метод фиксирования оплаты по заказу")]
        void PayRequest(int id);

        [CustomMethod("Метод пополнения компонент на складе")]
        void ReplenishFridge(FridgeIngredientBindingModel model);


    }
}
