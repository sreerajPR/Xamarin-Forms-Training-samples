using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RelativeLayoutDemo
{
  public class RelativeLayoutDemoCSharp : ContentPage
  {
    private const double boxWidth = 50;
    public RelativeLayoutDemoCSharp()
    {
      RelativeLayout parentRelativeLayout = new RelativeLayout();

      BoxView blueBox = new BoxView() { Color = Color.Blue };

      parentRelativeLayout.Children.Add(blueBox, Constraint.Constant(0),
        Constraint.Constant(0),
        Constraint.Constant(boxWidth),
        Constraint.Constant(boxWidth));

      BoxView redBox = new BoxView() { Color = Color.Red };

      parentRelativeLayout.Children.Add(redBox, Constraint.RelativeToParent((parent) =>
      {
        return parent.Width - boxWidth;
      }),
        Constraint.Constant(0),
        Constraint.Constant(boxWidth),
        Constraint.Constant(boxWidth));

      BoxView yellowBox = new BoxView() { Color = Color.Yellow };

      parentRelativeLayout.Children.Add(yellowBox, Constraint.RelativeToParent((parent) =>
      {
        return (parent.Width / 2) - (boxWidth / 2);
      }),
        Constraint.Constant(0),
        Constraint.Constant(boxWidth),
        Constraint.RelativeToParent((parent) =>
        {
          return parent.Height;
        }));

      BoxView greenBox = new BoxView() { Color = Color.Green };

      parentRelativeLayout.Children.Add(greenBox, Constraint.RelativeToView(yellowBox, (parent, sibling) =>
      {
        return sibling.X + sibling.Width;
      }),
        Constraint.RelativeToParent((parent) =>
        {
          return parent.Height - boxWidth;
        }),
        Constraint.Constant(boxWidth),
        Constraint.Constant(boxWidth));

      Content = parentRelativeLayout;
    }
  }
}