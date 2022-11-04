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
  HRZ_BLOCK_COUNT = (int)(STAGE_WIDTH / blockScale.x);
  VRT_BLOCK_COUNT = (int)(STAGE_HEIGHT / blockScale.y);

  Vector3 ballScale = blockScale * 0.9f;
  ball.transform.localScale = ballScale;
  
  for (int xBlockCount = 0; xBlockCount <= HRZ_BLOCK_COUNT; xBlockCount++) {
    for (int yBlockCount = 0; yBlockCount <= VRT_BLOCK_COUNT; yBlockCount++) {
      if(xBlockCount == 0 || xBlockCount == HRZ_BLOCK_COUNT || yBlockCount == 0 || yBlockCount == VRT_BLOCK_COUNT) {
        float xPos = -STAGE_WIDTH / 2.0f + (float)STAGE_WIDTH/HRZ_BLOCK_COUNT*xBlockCount;
        float yPos = -STAGE_HEIGHT / 2.0f + (float)STAGE_HEIGHT/VRT_BLOCK_COUNT*yBlockCount;

        Vector2 blockPos = new Vector2(xPos, yPos);
        Instantiate(wallBlock, blockPos, Quaternion.identity);
      }
    }
  }

  Instantiate(ball, Vector2.zero, Quaternion.identity);
}

// Update is called once per frame
void Update() { }
}
