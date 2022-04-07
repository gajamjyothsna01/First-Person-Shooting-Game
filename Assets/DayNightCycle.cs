using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    //public GameObject directionLight;
    public float minPerSeconds = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // directionLight.transform.rotation = Quaternion.Euler(30, 0, 0);
       float angleTheFrame = (Time.deltaTime/ 1) * minPerSeconds; //Day to night by rotating slowers
        transform.RotateAround(transform.position, Vector3.forward, angleTheFrame);

    }
}
