using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal interface IStructure
    {
        Guid Id { get; }

        string ToCode();
    }
}
