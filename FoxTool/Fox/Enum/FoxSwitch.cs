using System.Collections.Generic;

namespace FoxTool.Fox.Enum
{
    // Test data:
    ////<enums>
    ////    <enum type="switch" name="TppLensFlareShapeOffsetType">
    ////        <values>
    ////            <value name="OFFSET_TYPE_NO_MOVE" value="0"/>
    ////            <value name="OFFSET_TYPE_TOGETHER" value="1"/>
    ////            <value name="OFFSET_TYPE_MIRROR" value="2"/>
    ////            <value name="OFFSET_TYPE_X_MIRROR" value="3"/>
    ////            <value name="OFFSET_TYPE_Y_MIRROR" value="4"/>
    ////        </values>
    ////    </enum>
    ////    <enum type="switch" name="TppLensFlareShapeRotateType">
    ////        <values>
    ////            <value name="ROTATE_TYPE_NO_ROTATE" value="0"/>
    ////            <value name="ROTATE_TYPE_SAME" value="1"/>
    ////            <value name="ROTATE_TYPE_REVERSE" value="2"/>
    ////        </values>
    ////    </enum>
    ////    <enum type="switch" name="TppLensFlareShapeDistanceScalingMode">
    ////        <values>
    ////            <value name="DISTANCE_SCALING_MODE_NONE" value="0"/>
    ////            <value name="DISTANCE_SCALING_MODE_SIZESCALE" value="1"/>
    ////            <value name="DISTANCE_SCALING_MODE_ALPHASCALE" value="2"/>
    ////            <value name="DISTANCE_SCALING_MODE_SIZESCALE2" value="3"/>
    ////        </values>
    ////    </enum>
    ////    <enum type="switch" name="TppLensFlareFieldShapeType">
    ////        <values>
    ////            <value name="SHAPE_TYPE_SQUARE" value="0"/>
    ////            <value name="SHAPE_TYPE_CIRCLE" value="1"/>
    ////        </values>
    ////    </enum>
    ////    <enum type="switch" name="TppLensFlareFieldInterpType">
    ////        <values>
    ////            <value name="INTERP_TYPE_LINEAR" value="0"/>
    ////            <value name="INTERP_TYPE_COS" value="1"/>
    ////            <value name="INTERP_TYPE_SUDDEN" value="2"/>
    ////            <value name="INTERP_TYPE_BOWL" value="3"/>
    ////        </values>
    ////    </enum>
    ////</enums>
    ////<enum type="switch" name="TppAnimateObjectLocatorParameter_GimmickTypes">
    ////    <values>
    ////        <value name="TYPE_ANIMATE_DEFAULT" value="0"/>
    ////        <value name="TYPE_ANIMATED_BREAKABLE" value="1"/>
    ////        <value name="TYPE_CURTAIN" value="2"/>
    ////    </values>
    ////</enum>
    public class FoxSwitch : IFoxEnum
    {
        protected readonly List<FoxEnumValue> _values;

        protected FoxSwitch()
        {
            _values = new List<FoxEnumValue>();
        }

        public string Name { get; set; }

        public IEnumerable<FoxEnumValue> Values
        {
            get { return _values; }
        }
    }
}
