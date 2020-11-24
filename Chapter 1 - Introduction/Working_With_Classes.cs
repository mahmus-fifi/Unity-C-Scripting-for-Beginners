using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Working_With_Classes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject ourobj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        ourobj.transform.position = new Vector3(0f, 4.0f,0f);

        


       // Vector3 obj_v;
       // obj_v = new Vector3(0f,20f,10f);

       // Vector3 ourvect = new Vector3(0f,0f,0f);
       // float value = Input.GetAxis("Vertical");
       // transform.localPosition = new Vector3(20.0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
