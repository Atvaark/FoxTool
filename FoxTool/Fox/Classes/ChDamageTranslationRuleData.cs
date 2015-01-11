using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ChDamageTranslationRuleData : Data
    {
        public FoxString Key { get; set; }
        public FoxString DamageName { get; set; }
        public FoxPath ConditionScriptPath { get; set; }
        public FoxString TranslateScriptPath { get; set; }
    }
}
