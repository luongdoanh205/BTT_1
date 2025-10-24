using System;
using System.Collections.Generic;

namespace lvd_231230725_de02.Models;

public partial class LvdCatalog
{
    public int LvdId { get; set; }

    public string? LvdCateName { get; set; }

    public string? LvdCatePrice { get; set; }

    public string? LvdCateQty { get; set; }

    public string? LvdPicture { get; set; }

    public bool? LvdCateActive { get; set; }
}
