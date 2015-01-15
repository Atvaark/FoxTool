using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxTool.Fox.Enum
{
    public class TppLensFlareFieldShapeType : FoxSwitch
    {
        public static readonly TppLensFlareFieldShapeType Instance =
            new TppLensFlareFieldShapeType();

        public static readonly FoxEnumValue ShapeTypeSquare = new FoxEnumValue("SHAPE_TYPE_SQUARE", 0);
        public static readonly FoxEnumValue ShapeTypeCircle = new FoxEnumValue("SHAPE_TYPE_CIRCLE", 1);

        protected TppLensFlareFieldShapeType()
        {
            _values.Add(ShapeTypeSquare);
            _values.Add(ShapeTypeCircle);
        }
    }
}
