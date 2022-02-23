using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    public Rigidbody rb;
    move move;
    // Start is called before the first frame update
    void Start()
    {
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<move>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            rb.isKinematic = true;
            move.moving = true;
        }
        
    }
}
    
