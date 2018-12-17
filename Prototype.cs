namespace PrototypePattern
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();        

        protected string text;

        public string Text
        {
            get => text;
        }
    }
}