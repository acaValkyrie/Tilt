using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateWall : MonoBehaviour{
    [SerializeField] private GameObject wallBlock;
    [SerializeField] private GameObject ball;
    private const int STAGE_WIDTH = 16;
    private const int STAGE_HEIGHT = 9;
        
    // Start is called before the first frame update
    void Start() {
        for (float x = 0f; x <= STAGE_WIDTH; x+=0.5f) {
            for (float y = 0f; y <= STAGE_HEIGHT; y+=0.5f) {
                if(x == 0f || x == STAGE_WIDTH || y == 0f || y == STAGE_HEIGHT)
                {
                    Vector2 blockPos = new Vector2(x - STAGE_WIDTH/2.0f, y - STAGE_HEIGHT/2.0f);
                    Instantiate(wallBlock, blockPos, Quaternion.identity);
                }
            }
        }

        Instantiate(ball, Vector2.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
