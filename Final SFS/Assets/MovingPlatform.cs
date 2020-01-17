using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

	float dirY, moveSpeed = 3f;
	bool moveDown = true;

    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.y > 0.55f)
        {
            moveDown = false;
        }
        if (transform.position.y < -2.55f)
        {
            moveDown = true;
        }

        if (moveDown)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
    }
}
