using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float speed = 20f;

    public static event System.Action OnPinHitRotator;
    public static event System.Action OnPintHitPin;


    private bool pinned = false;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!pinned)
        {
            Vector2 posToMov = rb.position + Vector2.up * speed * Time.deltaTime;
            rb.MovePosition(posToMov);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            pinned = true;

            if (OnPinHitRotator != null)
            {
                OnPinHitRotator();
            }
        }
        else if (collision.tag == "Pin")
        {
            Debug.Log("You've lost");

            if (OnPintHitPin != null)
            {
                OnPintHitPin();
            }
        }
    }

    

}
