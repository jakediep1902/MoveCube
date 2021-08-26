using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    float x;
    Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(speed, 0, 0) * x * Time.deltaTime;
        if(x >0)
        {
            transform.localScale = new Vector2(0.8f, 0.8f);

        }
        if (x < 0)
        {
            transform.localScale = new Vector2(-0.8f, 0.8f);

        }

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            rb2d.AddForce(Vector2.up * jump);
        }
    }
}
