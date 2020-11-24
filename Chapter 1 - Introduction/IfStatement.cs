using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    public float num = 50.0f;
    public float num2 = 24.0f;
    // Start is called before the first frame update
    void Start()
    {
        //calling our if statement 
        // Ifstatement();
        IfElse();
    }
    void Ifstatement() {
        
        if (num > num2) {
            Debug.Log("num is greater than num2");

        }

        if (num < num2) {
            Debug.Log("num is less than num2");
        }


    }

    void IfElse() {
        if (num > num2)
        {
            Debug.Log("num is greater than num2");
        }
        else if (num < num2)
        {
            Debug.Log("num is lesser than num2");

        }
        else if (num == num2)
        {
            Debug.Log("Both numbers are the same");
        }

    }
}
