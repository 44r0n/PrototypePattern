namespace PrototypePattern
{
    public class ConcretePrototype1 : Prototype
    {
        public override Prototype Clone()
        {
            text = "ConcretePrototype1";
            return (Prototype)this.MemberwiseClone();
        }
    }
}