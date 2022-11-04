using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class InstantiateWall : MonoBehaviour{
[SerializeField] private GameObject wallBlock;
[SerializeField] private GameObject ball;
private const int STAGE_WIDTH = 16;
private const int STAGE_HEIGHT = 9;
private static int HRZ_BLOCK_COUNT = 16;//horizontal block count
private static int VRT_BLOCK_COUNT = 9;

// Start is called before the first frame update
void Start() {
  Vector3 blockScale = wallBlock.GetComponent<Transform>().localScale;
  Vector3 ballScale = blockScale * 0.7f;
  ball.transform.localScale = ballScale;
  Instantiate(ball, Vector2.zero, Quaternion.identity);

  HRZ_BLOCK_COUNT = (int)(STAGE_WIDTH / blockScale.x) + 1;
  VRT_BLOCK_COUNT = (int)(STAGE_HEIGHT / blockScale.y) + 1;
  byte[,] arr = new byte[HRZ_BLOCK_COUNT, VRT_BLOCK_COUNT];
  ArrayClear(arr);
  arr[2, 2] = 1;
  arr[3, 2] = 1;
  arr[4, 2] = 1;
  arr[5, 2] = 1;
  arr[6, 2] = 1;

  ArrayToStage(arr);
}

void ArrayClear(byte[,] array) {
  for(int y = 0; y < VRT_BLOCK_COUNT; y++) {
    for (int x = 0; x < HRZ_BLOCK_COUNT; x++) {
      array[x, y] = 0;
    }
  }
}

void ArrayToStage(byte[,] array) {
  for(int y = 0; y < VRT_BLOCK_COUNT; y++) {
    for (int x = 0; x < HRZ_BLOCK_COUNT; x++) {
      Debug.Log(array[x, y]);
    }
  }
  for (int xBlockCount = 0; xBlockCount < HRZ_BLOCK_COUNT; xBlockCount++) {
    for (int yBlockCount = 0; yBlockCount < VRT_BLOCK_COUNT; yBlockCount++) {
      if(xBlockCount == 0 || xBlockCount == HRZ_BLOCK_COUNT-1 || yBlockCount == 0 || yBlockCount == VRT_BLOCK_COUNT-1 || array[xBlockCount, yBlockCount] == 1) {
        float xPos = (1 - STAGE_WIDTH) / 2.0f + (float)STAGE_WIDTH/HRZ_BLOCK_COUNT*xBlockCount;
        float yPos = (1 - STAGE_HEIGHT) / 2.0f + (float)STAGE_HEIGHT/VRT_BLOCK_COUNT*yBlockCount;

        Vector2 blockPos = new Vector2(xPos, yPos);
        Instantiate(wallBlock, blockPos, Quaternion.identity);
      }
    }
  }
}

// Update is called once per frame
void Update() { }
}
