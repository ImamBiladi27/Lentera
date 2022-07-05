using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public static float jumpSpeed = 5f;
    //public GameObject Endscrn;
    public static float SPEED = 0.019997f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //base.jalan_kanan();
    }
    void Update()
    {
        

            Vector3 position = transform.position;
            if (Input.GetKey(KeyCode.A))
            {
                position.x -= SPEED;
            }
            if (Input.GetKey(KeyCode.D))
            {
                position.x += SPEED;
            }
             if (Input.GetKey(KeyCode.W))
            {
                position.y += SPEED;
            }
        if (Input.GetKey(KeyCode.S))
        {
            position.y -= SPEED;
        }
        transform.position = position;
            if (Input.GetKey(KeyCode.F))
            {
               jalan_kanan();
            }
        }

    public void jalan_kanan()
    {


        transform.position += Vector3.right * (SPEED* Time.deltaTime);

    }

}
