﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh5
{
    public partial class ViewInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name.InnerText = Server.MachineName;
            path.InnerText = Server.MapPath("");
        }
    }
}