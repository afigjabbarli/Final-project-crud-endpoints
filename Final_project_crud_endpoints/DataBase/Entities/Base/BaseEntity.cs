using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Final_project_crud_endpoints.DataBase.Entities.Base
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
