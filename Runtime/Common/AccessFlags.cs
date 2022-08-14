using System;

namespace Tuntenfisch.ScriptableObjectCoupling.Common
{
    [Flags]
    public enum AccessFlags
    {
        Unkown = 0,
        Read = 1 << 0,
        Write = 1 << 1
    }
}