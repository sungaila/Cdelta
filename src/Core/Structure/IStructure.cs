using System;

namespace Cdelta.Structure
{
    internal interface IStructure
    {
        Guid Id { get; }

        string ToCode();
    }
}
