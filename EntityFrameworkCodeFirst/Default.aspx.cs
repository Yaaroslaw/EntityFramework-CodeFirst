using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.IO;
using CodeFirst;

namespace EntityFrameworkCodeFirst
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Process the data from the Default.aspx Form

            if (Page.IsPostBack)
            {
                Model.Customer customer = new Model.Customer();

                // Получить данные из формы с помощью средств
                // привязки моделей ASP.NET
                IValueProvider provider = new FormValueProvider(ModelBindingExecutionContext);
                if (TryUpdateModel<Model.Customer>(customer, provider))
                {
                    // Загрузить фото профиля с помощью средств .NET
                    HttpPostedFile photo = Request.Files["photo"];
                    if (photo != null)
                    {
                        BinaryReader b = new BinaryReader(photo.InputStream);
                        customer.Photo = b.ReadBytes((int)photo.InputStream.Length);
                    }

                    // В этой точке непосредственно начинается работа с Entity Framework

                    // Создать объект контекста
                    SampleContext context = new SampleContext();

                    // Вставить данные в таблицу Customers с помощью LINQ
                    context.Customers.Add(customer);

                    // Сохранить изменения в БД
                    context.SaveChanges();
                }
            }


        }
    }
}