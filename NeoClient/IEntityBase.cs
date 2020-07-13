using System;
using System.Collections.Generic;
using System.Text;

namespace NeoClient
{
    public interface IEntityBase
    {
        string Label { get; set; }
        string Uuid { get; set; }
        bool IsDeleted { get; set; }
    }
}
