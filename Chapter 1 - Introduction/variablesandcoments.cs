using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Variablesandcoments : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FirstFunction(); //function that initialises variables 
        /*
         we can have 
         multiple line comments here 
         */
    }
    // Update is called once per frame
    void Update()
    {
        PlayerDead();
        HealthLow();        
    }
    void FirstFunction() {
        // we are declaring variables to use here
        string name = "Cat Nap";
        Vector3 point2 = new Vector3(0f, 0f, 0f);
        GameObject newobject = new GameObject();
        Vector2 points = new Vector2(10.0f, 10.0f);
        int Score = 40;
        bool istrue = false;
        float coins_collected = 23.55f;
        char firstletter = 'a';
        string title = "Super Adventures";
    }
    void PlayerDead() {
        //checks to see if the player is dead 
        bool isDead = true;
    }
    void HealthLow() {
        //checks if the players health is low 
    }
}
