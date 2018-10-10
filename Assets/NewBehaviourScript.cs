using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color color;
    public SpriteRenderer rend;
    public float movespeed = 5f;
    public float time;
    // Use this for initialization
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
    
        

        
        {
            transform.Translate(0, movespeed * Time.deltaTime, 0, Space.Self);
             
        }
        // Planet åker frammåt konstant.

        if (Input.GetKey ( KeyCode.A))
        {
            transform.Rotate(0, 0, 100 * Time.deltaTime);
            rend.color = new Color(0, 1, 0f);
            
        }
        //Om knappen (A) trycks ned, svänger flygplanet till vänster och byter ferg till grön.

        if (Input.GetKey( KeyCode.D))
        {
            transform.Rotate(0, 0, -180 * Time.deltaTime);
            rend.color = new Color(0, 0, 1f);
           
        } 
        //Om knappen (D) trycks ned, svänger flygplanet till höger och byter ferg till blå.

        if (Input.GetKey ( KeyCode.S))
        {
            transform.Translate(0, -movespeed/2  * Time.deltaTime, 0, Space.Self);
             
        }
        // Om knappen (S) trycks ned, Åker planet hälften så snabbt. 

        Timer();

    }
    void Timer()
    {
        time += 1 * Time.deltaTime;

        Debug.Log(string.Format("timer: {0}", time));
      
    } 
    // Timer som räknar upp i secunder. 
    
}


