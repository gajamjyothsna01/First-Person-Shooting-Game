using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Zoom Focus
public class CameraFocus : MonoBehaviour
{
     Camera cam;
    public float defaultView;
   
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //float inputZoom = cam.fieldOfView;
        if (Input.GetButton("ZoomView"))
        {
            cam.fieldOfView = 40f;
        }
        else
        {
            cam.fieldOfView = defaultView;
        }
        /* float zoomInput = Input.GetAxis("ZoomView");
         Debug.Log(zoomInput);   
         if(zoomInput > 0)
         {
             cam.fieldOfView = 40f;
         }
         else
         {
             cam.fieldOfView = 60f;
         }*/
    }
}
