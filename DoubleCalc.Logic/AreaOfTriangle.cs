using DoubleCalc.Model;

namespace DoubleCalc.Logic
{
    public class AreaOfTriangle : IAreaOfTriangle
    {
        public int TrigArea(AreaOfTriangleViewModel model)
        {
           var result = 1 / 2 * model.Base * model.Height;
            return result;
        }
    }
}
