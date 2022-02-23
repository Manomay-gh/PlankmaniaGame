using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falloff : MonoBehaviour
{
    public GameObject platformObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Plank"))
        {
            platformObj.SetActive(false);
        }
    }
}
