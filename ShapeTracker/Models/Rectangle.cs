using System;
using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    public int Side1 {get;set;}
    public int Side2 {get;set;}

    public Rectangle(int len1,int len2)
    {
      Side1 = len1;
      Side2 = len2;
    }

    public int FindArea()
    {
      return Side1 * Side2;
    }
  }
}