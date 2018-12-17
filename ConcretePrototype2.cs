namespace PrototypePattern
{
    public class ConcretePrototype2 : Prototype
    {
        public override Prototype Clone()
        {
            text = "ConcretePrototype2";
            return (Prototype)this.MemberwiseClone();
        }
    }
}