using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    

    public Animator animator;

    public bool end;

    public bool moving=true;
  
    public float speed=1;

    public bool facingLeft;

    public int count = 0;

    public AudioSource moveaudio,winsound;

    bool music = true, win=true;
    // Start is called before the first frame update
    void Start()
    {
        end = false;
        moving = false;

        moveaudio.Stop();
    }

    
    void Update()
    {
        

       
        if (moving==true) 
            {
            Debug.Log("Working");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            animator.SetBool("IsMoving", true);
              if(music==true)
              {
                moveaudio.Play();
                music = false;
              }
              if(this.transform.position.y<3f)
               {
                moveaudio.Stop();
               
               }
             
            }
        else
        {
            animator.SetBool("IsMoving", false);


            moveaudio.Stop();
            music = true;
        }
            
       
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("FlipCollider"))
        {
            
            moving = false;
            facingLeft = !facingLeft;
            flip();
            count++;

        }
        if (other.gameObject.CompareTag("Finish"))
        { 
            
            moving = false;
           
            flip();
            flip();
            animator.SetBool("End", true);
            count++;
            end = true;

            if (win == true)
            { winsound.Play();
                win = false;
            }

        }
        //SCENE CHANGE
        if (other.gameObject.CompareTag("Deathzone"))
        {
            Debug.Log("SceneChanged");
            Invoke("death", 0.3f);
            
        }
        
    }


    void flip()
    {
        if (facingLeft==true)
        {
            transform.Rotate(0f, -90f, 0f);
        }
        else if(facingLeft==false)
        {
            transform.Rotate(0f, 90f, 0f);
        }
    }

    void death()
    { if (LevelSelector.level == 2)
        {
            SceneManager.LoadScene("IceGameOver", LoadSceneMode.Single);
        }
      if(LevelSelector.level == 1)
        {
            SceneManager.LoadScene("SandGameOver", LoadSceneMode.Single);
        }
    }

}

