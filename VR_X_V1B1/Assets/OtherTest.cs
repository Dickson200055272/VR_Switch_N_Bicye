using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherTest : MonoBehaviour
{
    // Start is called before the first frame update
    bool isHasGyro;
    bool isHasGyo = false;
    public string GUItext, infoMsg;
    float x,y,z;
    public Vector3 Force;
   // public gameObject Ball;
    

    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {  
            Input.gyro.enabled = true; 
            isHasGyro = true;
            // infoMsg.text = "Using Gyroscope";
            Debug.Log("Using Gyroscope");
        }
        else
        {
            //infoMsg.text = "Not using Gyroscope"; 
            Debug.Log("Not using Gyroscope");
        }
    }

    void Update()
    {
        if (isHasGyro)
        {
            x = Input.gyro.attitude.x;
            y = Input.gyro.attitude.y;
            z = Input.gyro.attitude.z;  
            //infoMsg.text = "Using Gyroscope : " + x + " , " + y + " , " + z;
            Force = new Vector3(-x * 10.0F, 0.0F, -z * 10.0F);
        }
        //Ball.forward(force);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Input.gyro.attitude, 5.0F);

    }

    // Update is called once per frame

}
