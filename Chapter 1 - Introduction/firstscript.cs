using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class firstscript : MonoBehaviour
{
    public string  yourname = "Paul Phoenix";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello, my name is: " +yourname);      
    }
    // Update is called once per frame
    void Update()
    {     
        gameObject.transform.Translate(0f, 0.5f * Time.deltaTime, 0f);
        gameObject.transform.Rotate(0f, 0.5f * Time.deltaTime, 0f);
    }
}
