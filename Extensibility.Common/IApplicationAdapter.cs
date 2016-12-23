using System;

namespace Extensibility.Common
{
    public interface IApplicationAdapter
    {
        string Name { get; }

        void Initialize();
    }
}
