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
    [CustomInterface("Интерфейс для работы с выпечкой")]
    public interface ICakeService
    {
        [CustomMethod("Метод получения списка выпечки")]
        List<CakeViewModel> GetList();

        [CustomMethod("Метод получения выпечки по id")]
        CakeViewModel GetElement(int id);

        [CustomMethod("Метод добавления выпечки")]
        void AddElement(CakeBindingModel model);

        [CustomMethod("Метод изменения данных по выпечке")]
        void UpdElement(CakeBindingModel model);

        [CustomMethod("Метод удаления выпечки")]
        void DelElement(int id);
    }
}
