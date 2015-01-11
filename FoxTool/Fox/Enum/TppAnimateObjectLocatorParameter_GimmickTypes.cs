namespace FoxTool.Fox.Enum
{
    //name=TppAnimateObjectLocatorParameter_GimmickTypes
    public class TppAnimateObjectLocatorParameterGimmickTypes : FoxSwitch
    {
        private static readonly TppAnimateObjectLocatorParameterGimmickTypes Instance = new TppAnimateObjectLocatorParameterGimmickTypes();

        protected TppAnimateObjectLocatorParameterGimmickTypes()
        {
            _values.Add(TypeAnimateDefault);
            _values.Add(TypeAnimatedBreakable);
            _values.Add(TypeCurtain);
        }

        public static readonly FoxEnumValue TypeAnimateDefault = new FoxEnumValue("TYPE_ANIMATE_DEFAULT", 0);
        public static readonly FoxEnumValue TypeAnimatedBreakable = new FoxEnumValue("TYPE_ANIMATED_BREAKABLE", 1);
        public static readonly FoxEnumValue TypeCurtain = new FoxEnumValue("TYPE_CURTAIN", 2);
    }
}