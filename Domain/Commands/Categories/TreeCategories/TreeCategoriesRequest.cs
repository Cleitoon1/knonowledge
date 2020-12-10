using System.Collections.Generic;
using MediatR;

namespace Domain.Commands.Categories.TreeCategories
{
    public class TreeCategoriesRequest : IRequest<Response>
    {
        public int? parentCategoryId { get; set; }
    }
}