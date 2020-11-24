using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTheCube : MonoBehaviour
{
    float negative = -1.0f;
    public float speed = 0f;
    void GameObjectMove() {
        float h = Input.GetAxis("Horizontal");
        Debug.Log("the Value of h is: " +h);
        if (h > 0) {
            gameObject.transform.Rotate(0f, speed * Time.deltaTime, 0f);

        }
        else if (h < 0)
        {
            gameObject.transform.Rotate(0f,negative* speed * Time.deltaTime, 0f);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        GameObjectMove();
    }
}
