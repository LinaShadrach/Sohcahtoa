using System;

namespace Sohcahtoa.Objects
{
    public class Triangle
    {
        private double _angle;
        private double _angleInRad;
        private double _opposite;
        private double _adjacent;
        private double _hypotenuse;

        public double GetAngle() {
            return _angle;
        }

        public void SetAngle(double angle) {
            _angle = angle;
        }

        public double GetAngleInRad() {
            return _angleInRad;
        }

        public void SetAngleInRad(double angle) {
            _angleInRad = angle * (Math.PI/180);
        }
        public double GetOpposite() {
            return _opposite;
        }

        public void SetOpposite(double opposite) {
            _opposite = opposite;
        }

        public double GetAdjacent() {
            return _adjacent;
        }

        public void SetAdjacent(double adjacent) {
            _adjacent = adjacent;
        }

        public double GetHypotenuse() {
            return _hypotenuse;
        }

        public void SetHypotenuse(double hypotenuse) {
            _hypotenuse = hypotenuse;
        }

        public void DetermineHypotenuse() {
            Console.WriteLine(_opposite.ToString());
            Console.WriteLine(_angle.ToString());
            double hypotenuse = (_opposite / Math.Sin(_angleInRad));
            Console.WriteLine(hypotenuse.ToString());
            SetHypotenuse(hypotenuse);
        }

        public void DetermineAdjacent() {
            double adjacent = (_opposite / Math.Tan(_angleInRad));
            SetAdjacent(adjacent);
        }
    }
}
