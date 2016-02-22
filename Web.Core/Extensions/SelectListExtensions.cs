using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;
using Core.Entites.Models;


namespace Web.Core.Extensions
{
    public static class SelectListExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<ProjectType> metrics, int selectedId)
        {
            return
                metrics.OrderBy(projectType => projectType.Name)
                      .Select(projectType =>
                          new SelectListItem
                          {
                              Selected = (projectType.Id == selectedId),
                              Text = projectType.Name,
                              Value = projectType.Id.ToString()
                          });
        }
      
    }
}
