using System;
using System.Collections.Generic;
using System.Text;

namespace FF11
{
    // ----Lyckas stoppa alla maskiner med en metod----
    public class FoldingMachine
    {
        public void StopFolding()
        {
            Console.WriteLine("Stopping folding");
        }
    }

    public class WeldingMachine
    {
        public void StopWelding()
        {
            Console.WriteLine("Stopping welding");
        }
    }

    public class PaintingMachine
    {
        public void TurnOffPaint()
        {
            Console.WriteLine("Stopping painting");
        }
    }


    public class Factory
    {
        public delegate void StopMachineDelegate();

        //public StopMachineDelegate StopMachines;
        public StopMachineDelegate StopMachines { get; set; }

        public void STOP()
        {
            if (StopMachines != null)
            {
                StopMachines();
            }
            
        }


    }
}
