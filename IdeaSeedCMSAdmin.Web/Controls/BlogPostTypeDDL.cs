﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeedCMS.Core.Domain;
using IdeaSeedCMS.Services;
using Telerik.Web.UI;
using IdeaSeed.Web.UI;

namespace IdeaSeedCMSAdmin.Web.Controls
{
    public class BlogPostTypeDDL : DropDownList
    {
        public BlogPostTypeDDL()
        {
            this.Items.Clear();
            this.EmptyMessage = "-- Select --";
            this.Items.Add(new RadComboBoxItem("", ""));
            this.Skin = "Metro";
            foreach (var s in Enum.GetValues(typeof(IdeaSeedCMS.Core.Domain.BlogPostType)))
            {
                this.Items.Add(new RadComboBoxItem(Enum.GetName(typeof(IdeaSeedCMS.Core.Domain.BlogPostType), Convert.ToInt16(s)), Convert.ToInt16(s).ToString()));
            }
        }
    }
}