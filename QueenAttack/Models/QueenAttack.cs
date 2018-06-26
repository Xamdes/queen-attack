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
      bool canAttack = false;
      //Check Horizontal or vertical return true
      if(x == xCoord || y == yCoord)
      {
        canAttack = true;
      }
      //Logic for checking if coordinates are vertical
      else if(false)
      {

      }
      return canAttack;
    }

    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
