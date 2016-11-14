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
        private double _leg;
        private string _side;

        public double GetAngle()
        {
            return _angle;
        }
        public void SetAngle(double angle)
        {
            _angle = angle;
        }

        public double GetAngleInRad()
        {
            return _angleInRad;
        }
        public void SetAngleInRad(double angle) {
            _angleInRad = angle * (Math.PI/180);
        }


        public double GetOpposite()
        {
            return _opposite;
        }
        public void SetOpposite(double opposite)
        {
            _opposite = opposite;
        }

        public double GetAdjacent()
        {
            return _adjacent;
        }
        public void SetAdjacent(double adjacent)
        {
            _adjacent = adjacent;
        }

        public double GetHypotenuse()
        {
            return _hypotenuse;
        }
        public void SetHypotenuse(double hypotenuse)
        {
            _hypotenuse = hypotenuse;
        }

        public double GetLeg()
        {
            return _leg;
        }
        public void SetLeg(double leg)
        {
            _leg = leg;
        }

        public string GetSide()
        {
            return _side;
        }
        public void SetSide(string side)
        {
            _side = side;
        }

        public void SinHyp()
        {
            double hypotenuse = (_opposite / Math.Sin(_angleInRad));
            SetHypotenuse(hypotenuse);
        }
        public void SinOpp(){
            double opposite = (_hypotenuse * Math.Sin(_angleInRad));
            SetOpposite(opposite);
        }
        public void Cah()
        {
            double hypotenuse = (_adjacent / Math.Cos(_angleInRad));
            SetHypotenuse(hypotenuse);
        }
        public void TanAdj()
        {
            double adjacent = (_opposite / Math.Tan(_angleInRad));
            SetAdjacent(adjacent);
        }
        public void TanOpp()
        {
            double opposite = (_adjacent * Math.Tan(_angleInRad));
            SetOpposite(opposite);
        }
        public void makeTriangle()
        {
            if(_side == "opposite")
            {
                _opposite = _leg;
                SinHyp();
                TanAdj();

            }
            if(_side == "adjacent")
            {
                _adjacent = _leg;
                Cah();
                TanOpp();
            }
            if(_side == "hypotenuse")
            {
                _hypotenuse = _leg;
                SinOpp();
                TanAdj();
            }

        }


    }



}
