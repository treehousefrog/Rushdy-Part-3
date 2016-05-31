using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour
{

    public float amounttomovex;
    public float speed;
    private float currentposx;
    private float currentposy;
    private int facing;
    
    // Use this for initialization
    void Start()
    {
        currentposx = gameObject.transform.position.x;
        facing = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (facing == 1 && gameObject.transform.position.x < currentposx - amounttomovex)
        {
            facing = 0;
        }

        if (facing == 0 && gameObject.transform.position.x > currentposx)
        {
            facing = 1;
        }

        
            if (facing == 0)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);

            }
            else if (facing == 1)
            {
                transform.Translate(-Vector2.right * speed * Time.deltaTime);
            }
        }
        

    }