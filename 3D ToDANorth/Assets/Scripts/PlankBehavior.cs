using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlankBehavior : MonoBehaviour
{
    public bool Android = false;
    public float rotateSpeed = 10;
    public float scaleSpeed = 1;
    bool sizeincrease = true;
    bool changingSize =true;
    
    public bool plankDone=false;
    public float plankMaxSize = 5;
    public Rigidbody rb;
    Renderer color;
    move move;

   

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponentInChildren<Renderer>();

        if(Application.platform==RuntimePlatform.Android)
        {
            Android = true;
        }
        else
        {
            Android = false;
        }
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<move>();
    }

    // Update is called once per frame
    void Update()
    {
       

            if (changingSize==true)
            {
                if (Input.GetMouseButton(0))
                {
                    if (transform.localScale.x < 1)
                    {
                        sizeincrease = true;
                    }
                    else if (transform.localScale.x > plankMaxSize)
                    {
                        sizeincrease = false;
                    }

                    if (sizeincrease)
                    {
                        transform.localScale += new Vector3(1, 0, 0) * Time.deltaTime * scaleSpeed;
                    }
                    else
                    {
                        transform.localScale -= new Vector3(1, 0, 0) * Time.deltaTime * scaleSpeed;
                    }
                }
                if (Input.GetMouseButtonUp(0))
                {
                    changingSize = false;

                }
            }
        

        if (changingSize == false)
        {
            if (plankDone == false)
            {

                if (this.transform.eulerAngles.z > 1f && this.transform.eulerAngles.z < 90f)
                {
                    transform.Rotate(Vector3.forward * -rotateSpeed * Time.deltaTime);
                    rb.isKinematic = false;
                }

                else
                {

                    plankDone = true;
                   // move.moving = true;

                }
            }
        }



    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Deathzone"))
        {
            Debug.Log("SceneChanged");
            move.moving = true;
            color.material.color = Color.red;
            //Invoke("loadscenefunc", 0.8f);
        }
        if(other.gameObject.CompareTag("FallOffDetect"))
        {
            Debug.Log("ColorChanged");
            color.material.color = Color.red;
        }

    }

    void loadscenefunc()
    {
        SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
    }

}
