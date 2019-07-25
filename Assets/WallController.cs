using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public int Score;
    public GameObject Brick;
    
    void Start()
    {
        int cntRow = 0;
        while(cntRow < 10)
        {
            int cntCol = 0;
            while (cntCol < 10)
            {
                Vector3 position;
                if(cntRow % 2 == 1)//kazdou lichou radku
                {
                    position = new Vector3(0f, cntRow + 1f, cntCol * 2f + 1f);
                }
                else//kazdou sudou radku
                {
                    position = new Vector3(0f, cntRow + 1f, cntCol * 2f);
                }
                
                Instantiate(Brick, position, transform.rotation);
                cntCol = cntCol + 1;
            }
            cntRow++;             
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Score++;
        }
    }
}
