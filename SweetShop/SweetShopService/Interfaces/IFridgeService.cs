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
    [CustomInterface("Интерфейс для работы со холодильникамиами")]
    public interface IFridgeService
    {
        [CustomMethod("Метод получения списка холодильникамиов")]
        List<FridgeViewModel> GetList();

        [CustomMethod("Метод получения холодильникамиа по id")]
        FridgeViewModel GetElement(int id);

        [CustomMethod("Метод добавления холодильникамиа")]
        void AddElement(FridgeBindingModel model);

        [CustomMethod("Метод изменения данных по холодильникамиу")]
        void UpdElement(FridgeBindingModel model);

        [CustomMethod("Метод удаления холодильникамиа")]
        void DelElement(int id);
    }
}
