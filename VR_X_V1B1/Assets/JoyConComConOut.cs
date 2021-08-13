using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyConComConOut : MonoBehaviour
{

    public float GetJCX; 
    public float PositX, PositY , PositZ;
    public Vector3 popov3;
    static Quaternion speed;
    public GameObject Cant, Bell;
    private JoyconDemo TT;

    // Start is called before the first frame update
    void Start()
    {
       
       // var myVector = GameObject.Find("LJoycon").transform.position;
        // JoyconDemo cp = GetComment<JoyconDemo>();
    }

    // Update is called once per frame
    void Update()
    {
        
         TT = Cant.GetComponent<JoyconDemo>();
        
        
        speed = TT.orientation;
        popov3  = TT.accel;
        //transform.Rotate(0, 0, PositX * Time.deltaTime);

        if (popov3.x* Time.deltaTime >1)
        {
            //Bell.transform.position ==(position.x,position.y, position.z--);
            Vector3 temp = transform.position;
            temp.z++;
            transform.position = temp;
        }

        /*
        transform.InverseTransformDirection(ant.angularVelocity).y;
        if (transform.rotation.y != lastRot.y && transform.rotation.y - lastRot.y >= 0)
        {

        }

        */







        /*
         if (ggyro >= 20 && go == false)
        {
            go = true;
        }

        if (ggyro < 20 && go == true)
        {
            //stepCount += 1;
            go = false;
        }

        //check if object is rotating
        if (transform.rotation.y != this.lastRot.y && transform.rotation.y - lastRot.y >= 0)
        {
            speed++;
        }


        if (transform.rotation.y != this.lastRot.y && transform.rotation.y - lastRot.y <= 0)
        {
            speed--;
        }

        */
        //lastRot = transform.rotation;





        //gyro = j.GetGyro() = GetJCX;


        /*object.tag("RunBar")
        {
        if (GetJCX > 1)
        {
            PositX == GetJCX;
        }
            transform.position = new Vector3(PositX, position.y);
        }
        */


    }

 
}
