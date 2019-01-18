using System;
using System.Collections.Generic;
using System.Text;

namespace Teach_man.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Maths,
        Science
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
