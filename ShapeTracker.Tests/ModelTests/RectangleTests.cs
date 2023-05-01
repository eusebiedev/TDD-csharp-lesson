using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests // : IDisposable
  {
    // public void Dispose()
    // {
    //     Rectangle.ClearAll();
    // }
    //tests
    [TestMethod]
    public void RectangleConstructor_CreateRectangleConstructor_Rectangle()
    {
      Rectangle rect = new Rectangle(4,2);
      Assert.AreEqual(typeof(Rectangle),rect.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      //Arrange
      int len1 = 4;
      int len2 = 7;
      Rectangle rect = new Rectangle(len1, len2);
      //Act
      int result = rect.Side1;
      //Assert
      Assert.AreEqual(len1, result);
    }
    
    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      //Arrange
      int len1 = 4;
      int len2 = 7;
      Rectangle rect = new Rectangle(len1, len2);
      //Act
      int result = rect.Side2;
      //Assert
      Assert.AreEqual(len2, result);
    }

    [TestMethod]
    public void FindArea_ReturnArea_int()
    {
      Rectangle rect = new Rectangle(2,5);
      int area = rect.FindArea();
      Assert.AreEqual(area,10);
    }
  }
}