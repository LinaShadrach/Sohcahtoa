using Nancy;
using Sohcahtoa.Objects;

namespace Sohcahtoa
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get ["/form"] = _ => {
                return View["form.cshtml"];
            };
            Get ["/displayTriangle"] = _ => {
                Triangle myTriangle = new Triangle();
                myTriangle.SetAngle(double.Parse(Request.Query["angle"]));
                myTriangle.SetSide(Request.Query["side"]);
                myTriangle.SetLeg(double.Parse(Request.Query["leg"]));
                myTriangle.SetAngleInRad(myTriangle.GetAngle());
                myTriangle.makeTriangle();
                return View["displayTriangle.cshtml", myTriangle];
            };
        }
    }
}
