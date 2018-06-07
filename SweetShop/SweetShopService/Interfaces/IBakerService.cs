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
    [CustomInterface("Интерфейс для работы с пекарями")]
    public interface IBakerService
    {
        [CustomMethod("Метод получения списка пекарей")]
        List<BakerViewModel> GetList();

        [CustomMethod("Метод получения пекаря по id")]
        BakerViewModel GetElement(int id);

        [CustomMethod("Метод добавления пекаря")]
        void AddElement(BakerBindingModel model);

        [CustomMethod("Метод изменения данных по пекарю")]
        void UpdElement(BakerBindingModel model);

        [CustomMethod("Метод удаления пекаря")]
        void DelElement(int id);
    }
}
