using System;
using System.Linq;

namespace Dsd
{
    public interface ICounter
    {
        void Aumentar();

        int CurrentCount { get; set; }
    }
}
