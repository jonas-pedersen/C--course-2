using System;
using System.Collections.Generic;
using System.Text;

namespace FF11
{
    class FoldingMachine
    {
        public void StopFolding() { Console.WriteLine("Stopping folding"); }
    }

    class WeldingMachine
    {
        public void StopWelding() { Console.WriteLine("Stopping welding"); }
    }

    class PaintingMachine
    {
        public void TurnOffPaint() { Console.WriteLine("Stopping painting"); }
    }

    class Factory
    {
        public delegate void StopMachineDelegate();

        public StopMachineDelegate StopMachines;

        public void STOP()
        {
            if (StopMachines != null)
            {
                StopMachines();
            }
        }
    }
}
