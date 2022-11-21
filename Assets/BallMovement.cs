using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5)
        {
            Vector3 offset2 = new Vector3(0, 3, 0) * Time.deltaTime;
                    transform.Translate(offset2, Space.World);
        }
        else if (transform.position.y >= 5 && transform.position.x >=5)
        {
            Vector3 offset4 = new Vector3(0, -3, 0) * Time.deltaTime;
            transform.Translate(offset4, Space.World);
        }
        else if (transform.position.x <= 5)
        {
            Vector3 offset = new Vector3(3, 0, 0) * Time.deltaTime;
                    transform.Translate(offset, Space.World);
        }
        else if (transform.position.x >= 5 && transform.position.y >= 5)
        {
            Vector3 offset3 = new Vector3(-3, 0, 0) * Time.deltaTime;
            transform.Translate(offset3, Space.World);
        }
    }
}
