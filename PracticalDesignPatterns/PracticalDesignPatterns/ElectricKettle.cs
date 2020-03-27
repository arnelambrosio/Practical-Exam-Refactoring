using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns
{
    public sealed class ElectricKettle
    {
        private static readonly Lazy<ElectricKettle> lazy =
            new Lazy<ElectricKettle>(() => new ElectricKettle());

        public static ElectricKettle Instance { get { return lazy.Value; } }
        public Status Status { get; private set; } = Status.Empty;

        private ElectricKettle() { }

        public string Fill()
        {
            Status = Status.InProgress;
            return "Filling...";
        }

        public string Drain()
        {
            Status = Status.Empty;
            return "Draining...";
        }

        public string Boil()
        {
            Status = Status.Boiled;
            return "Boiling...";
        }
    }

    //Refactor to be in separate file
    public enum Status
    {
        Empty,
        InProgress,
        Boiled
    }
}
