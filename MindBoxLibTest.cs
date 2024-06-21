using MindBoxLib;

namespace MindBoxLibTests;

public class MindBoxLibTest
{
    [Fact]
    public void CircleArea_Radius3_9PiReturned()
    {
        //arrange
        IArea circle = new Circle(3);
        
        //act
        var area = AreaCalculator.Calculate(circle);
        
        //assert
        Assert.Equal(Math.PI*3*3, area, 3);
    }

    [Fact]
    public void TriangleArea_Sides3_4_5_6Returned()
    {
        //arrange
        IArea triangle = new Triangle(3, 4, 5);
        
        //act
        var area = AreaCalculator.Calculate(triangle);
        
        //assert
        Assert.Equal(6, area, 3);
    }

    [Fact]
    public void IsRightTriangle_Sides3_4_5_TrueReturned()
    {
        //arrange
        var triangle = new Triangle(3, 4, 5);
        
        //act
        var isRight = triangle.IsRightTriangle();
        
        //assert
        Assert.True(isRight);
    }

    [Fact]
    public void IsRightTriangle_Sides3_3_3_FalseReturned()
    {
        //arrange
        var triangle = new Triangle(3, 3, 3);
        
        //act
        var isRight = triangle.IsRightTriangle();
        
        //assert
        Assert.False(isRight);
    }

    [Fact]
    public void Triangle_Sides_1_2_3_ThrowsNotTriangleException()
    {
        //arrange
        double a = 1, b = 2, c = 3;
        
        //act&assert
        Assert.Throws<NotTriangleException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void Circle_Radius0_ThrowsNotCircleException()
    {
        //arrange
        double radius = 0;
        
        //act&assert
        Assert.Throws<NotCircleException>(() => new Circle(radius));
    }
}