namespace Triangle
{
  public class Triangle
  {
    public bool IsTriangle(int one, int two, int three)
    {
      if (one + two > three && one + three > two && two + three > one)
      {
        return true;
      } else
      {
        return false;
      }
    }
    public bool IsEquilateral(int one, int two, int three)
    {
      if (one == two && two == three)
      {
        return true;
      } else 
      {
        return false;
      }
    }
    public bool IsIsosceles(int one, int two, int three)
    {
      if (one == two || one == three || two == three)
      {
        return true;
      } else
      {
        return false;
      }
    }
  }
}