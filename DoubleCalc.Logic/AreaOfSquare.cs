using DoubleCalc.Model;

namespace DoubleCalc.Logic
{
    public class AreaOfSquare : IAreaOfSquare
    {
        public int SquareArea(AreaOfSquareViewModel model)
        {
            var result = model.Length * model.Breadth;
            return result;
        }
    }
}
