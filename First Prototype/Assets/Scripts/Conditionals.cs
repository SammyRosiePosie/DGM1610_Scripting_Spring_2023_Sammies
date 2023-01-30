using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public int time = 100;

    public string weather = "Clear";

    public bool isStopLightRed = true;

    float gpa = 3.25f;

    double temperature = 101.5d;

    // Start is called before the first frame update
    void Start()
    {
        //Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("Its too early go back to bed!");
        }

        //Check Weatherd
        if(weather == "Cloudy")
        {
            Debug.Log("It is cloudy outside");
        }
         else if (weather == "Raining")
        {
            Debug.Log("It is pouring out there!");
        }
          else if (weather == "Clear")
        {
            Debug.Log("Enjoy the sun boi, go playing in the light!");
        }
          else if (weather == "ThunderLightning")
        {
            Debug.Log("Zeus is mad!");
        }
            else if (weather == "Snowing")
        {
            Debug.Log("Elsa, popped in, bundle up.");
        }
        else 
        {
            Debug.Log("Weather unclear, check again later.");
        }

        /*
        if(condition_01)
        {
            //If condition_01 is true run this code
        }
        else if(condition_02)
        {
            //If condition_02 is true run this code
        }
        else
        {
            //If o toehr conditions are true run this code
        }
        */


        //Check the stop light color
        if(isStopLightRed = false)
        {
            Debug.Log("Go Go Go Go!!!");
        }
        else
        {
            Debug.Log("You had better not move.");
        }

        //Check gpa of daughter
        if(gpa == 4.0f)
        {
            Debug.Log("You can go hang out with your friends.");
        }
        else if(gpa == 1.5f)
        {
            Debug.Log("You are grounded till you're gpa improves.");
        }
        else 
        {
            Debug.Log("You need to study more. I'll get you a tutor tomorrow.");
        }

         //Check temperature
        if(temperature <= 40d)
        {
            Debug.Log("It's too cold stay in1");
        }
         else if (temperature < 65d)
        {
            Debug.Log("Good Temp, can go out shopping.");
        }
        else 
        {
            Debug.Log("Too hot, don't leave, the magic air of ac");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
