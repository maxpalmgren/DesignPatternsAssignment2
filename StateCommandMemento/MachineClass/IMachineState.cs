namespace Assignment2.StateCommandMemento.MachineClass
{
    public interface IMachineState
    {
        public void PowerSwitch();
        public void Print(string text);
    }
}