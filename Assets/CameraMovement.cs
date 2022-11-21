using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CameraMovement : MonoBehaviour
{
    
    [SerializeField]
    private int moveSpeed = 10;
    
    
    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            // Move forwards
            //Vector3 cameraPosition = this.gameObject.transform.position;
            //Vector3 offset = new Vector3(0, 0, moveSpeed);
            //this.gameObject.transform.position = cameraPosition + offset * Time.deltaTime;
            //transform.position = cameraPosition + offset * Time.deltaTime;
            Vector3 offset = new Vector3(0, 0, 1) * Time.deltaTime;
            transform.Translate(offset, Space.World);
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Move backwards
            //Vector3 cameraPosition = this.gameObject.transform.position;
            //Vector3 offset = new Vector3(0, 0, moveSpeed);
            //this.gameObject.transform.position = cameraPosition - offset * Time.deltaTime;
            Vector3 offset = new Vector3(0, 0, -1) * Time.deltaTime;
            transform.Translate(offset);
        }    
        
        if (Input.GetKey(KeyCode.A))
        {
            // Move lefts
            //Vector3 cameraPosition = this.gameObject.transform.position;
            //Vector3 offset = new Vector3(moveSpeed, 0, 0);
            //this.gameObject.transform.position = cameraPosition - offset * Time.deltaTime;
            Vector3 offset = new Vector3(-1, 0, 0) * Time.deltaTime;
            transform.Translate(offset);
        }  
        
        else if (Input.GetKey(KeyCode.D))
        {
            // Move rights
            //Vector3 cameraPosition = this.gameObject.transform.position;
            //Vector3 offset = new Vector3(moveSpeed, 0, 0);
            //this.gameObject.transform.position = cameraPosition + offset * Time.deltaTime;
            Vector3 offset = new Vector3(+1, 0, 0) * Time.deltaTime;
            transform.Translate(offset);
        }

        // Rotate camera
        float rotation = Input.GetAxis("Mouse X");
        transform.Rotate(0,rotation,0);
        // transform.Translate

    }
}
