using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Operators : MonoBehaviour
{
    public float first_num = 23.09f;
    public float second_num = 44.56f;
    /*
     addition + ,
     multiplication * ,
     division /,
     less than or exqals <= 
     greater than or equals >= ,
     comparison ==,
     assignment operator =
         int age = 3  assigning 
         2 == 2  check if the expression on the left is equal to the expression on the right 
         */
    // Start is called before the first frame update
    void OperatorFunction()
    {
        float add = first_num + second_num;
        float multiply = first_num * second_num;
        Debug.Log("Addition Results: " + add);
        Debug.Log("Multiplication Results: " + multiply);
    }
    void Start()
    {
//calling our operator function that adds and multiplies two float numbers
        OperatorFunction();
       
    }
// Update is called once per frame
    void Update()
    {
     
        
    }
}
