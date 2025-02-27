using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody rb;
    private Vector3 direction = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Wall"))
        {
            direction = -direction;
        }
    }
}
