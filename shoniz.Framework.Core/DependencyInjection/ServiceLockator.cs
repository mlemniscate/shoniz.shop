namespace shoniz.Framework.Core.DependencyInjection
{
    public static class ServiceLockator
    {
        public static IDiContainer Current { get; private set; }
        public static void Initial(IDiContainer container)
        {
            if(Current == null)
            {
                Current = container;
            }
        }
    }
}
