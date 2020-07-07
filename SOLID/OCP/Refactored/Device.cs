namespace SOLID.OCP.Refactored
{
    //common functionality over all devices..
    public abstract class Device
    {
        public abstract void Accept(IDeviceVisitor visitor);
    }
}
