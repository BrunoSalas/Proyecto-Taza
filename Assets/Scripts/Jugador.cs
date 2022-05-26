using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dire = (transform.forward * vertical + transform.right * horizontal).normalized;
        if (dire == Vector3.zero)
        {
            return;
        }
           
        Quaternion targetRotation = Quaternion.LookRotation(dire);
        targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360 * Time.fixedDeltaTime);
            
        rb.MovePosition(transform.position + dire * speed * Time.fixedDeltaTime);
        rb.MoveRotation(targetRotation);
        
    }
}
