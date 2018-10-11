using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color color;
    public SpriteRenderer rend;
    public float movespeed = 5f;
    public float timer;
    public float x = 8;
    public float y = 4;
    public float z = 180;
    
    public float counter;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3 (Random.Range(-x, x), Random.Range(-y, y));
        // Random start spawn. 

        transform.eulerAngles = new Vector3 (0f, 0f, Random.Range(-z, z ));
        // Random spawn rotation. 
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

        if (Input.GetKey( KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1)); 
            
        }
        // Random fergnyanser inom R,G,B från 0,1 till 1,0.


        counter += Time.deltaTime; 
        if (counter >= timer +1)
        {
          timer +=1;
            print("timer" + ' ' + timer);

        }
        // Timer räknar upp varge secund.
    
        

       
      
    
    // Timer som räknar upp i secunder. 
    }
}


