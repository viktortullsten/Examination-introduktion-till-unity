using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color color;
    public SpriteRenderer rend;
    public float movespeed = 10f;
    public float time;
    // Use this for initialization
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rend.color = new Color(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.G))
        {
            rend.color = new Color(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.B))
        {
            rend.color = new Color(0, 0, 1f);
        }

        
        {
            transform.Translate(0, movespeed * Time.deltaTime, 0, Space.Self);
        }

        if (Input.GetKey ( KeyCode.A))
        {
            transform.Rotate(0, 0, 100 * Time.deltaTime);
            rend.color = new Color(0, 1, 0f);
        }

        if (Input.GetKey( KeyCode.D))
        {
            transform.Rotate(0, 0, -180 * Time.deltaTime);
            rend.color = new Color(0, 0, 1f);
        }
        if (Input.GetKey ( KeyCode.S))
        {
            transform.Translate(0, -movespeed/2  * Time.deltaTime, 0, Space.Self);
        }
        Timer();

    }
    void Timer()
    {
        time += 1 * Time.deltaTime;

        Debug.Log(string.Format("timer: {0}", time));
       
    }
    





}


