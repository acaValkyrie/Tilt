using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeScript {
  private static Vector2 mazeSize = InstantiateWall.GetStageBlockSize();
  private static byte[,] mazeArr = new byte[(int)mazeSize.x, (int)mazeSize.y];

  public static byte[,] GetMazeArr()
  {
    return mazeArr;
  }
  
  public static void BuildMaze()
  {
    mazeArr[2, 4] = 1;
    mazeArr[2, 5] = 1;
    mazeArr[4, 5] = 1;
    mazeArr[4, 6] = 1;
    mazeArr[6, 6] = 1;
    mazeArr[6, 7] = 1;
    mazeArr[8, 7] = 1;

  }

}
