using System;
namespace QueenAttack
{
  public class Queen
  {
    private int xCoord;
    private int yCoord;
    public Queen()
    {
      xCoord = 0;
      yCoord = 0;
    }
    public Queen(int x,int y)
    {
      xCoord = x;
      yCoord = y;
    }
    public int GetX()
    {
      return xCoord;
    }
    public int GetY()
    {
      return yCoord;
    }
    public bool Move(int x, int y)
    {
      xCoord = x;
      yCoord = y;
      return true;
    }

    public bool CanAttack(int x, int y)
    {
      //Check Horizontal or vertical return true
      return (x == xCoord || y == yCoord || isVertical(x,y));
    }

    public bool isVertical(int x2, int y2)
    {
      double m = Math.Abs((y2-yCoord)/(x2-xCoord));
      return (m == 1);

    }

    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
