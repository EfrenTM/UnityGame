using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float moverH = Input.GetAxis("Horizontal");
        float moverV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moverH, 0.0f, moverV)*10;
        rb.AddForce(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * speed;
        }

    }


}
