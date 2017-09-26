using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //speed que aplicaremos
    public float speed;
    public Rigidbody rb;
    //metodo Update
    private void Update()
    {
                
    }
    //para aplicar fuerzas o acciones que tengan que ver con las fisicas usar FixedUpdate()
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(move * speed);

    }
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
}
