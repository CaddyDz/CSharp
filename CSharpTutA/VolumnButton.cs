using System;

namespace CSharpTutA
{
    class VolumnButton : ICommand
    {
        IElectronicDevice device;

        public VolumnButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.VolumnUp();
        }

        public void Undo()
        {
            device.VolumnDown();
        }
    }
}
