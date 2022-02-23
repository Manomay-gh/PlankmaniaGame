using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public static int score;

    public Image Score100, Score30, Score0;
    float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Score100.gameObject.SetActive(false);
        Score30.gameObject.SetActive(false);
        Score0.gameObject.SetActive(false);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Score100")&&count==0)
        {
            score = score + 100;
            count = 1;
            Score100.gameObject.SetActive(true);

            Invoke("Score100close", 1f);

        }
        else if(other.gameObject.CompareTag("Score30") && count == 0)
        {
            score = score + 30;
            count = 1;
            Score30.gameObject.SetActive(true);
            Invoke("Score30close", 1f);

        }
        else if (other.gameObject.CompareTag("Score0") && count == 0)
        {
            score = score + 0;
            count = 1;
            Score0.gameObject.SetActive(true);
            Invoke("Score0close", 1f);

        }
        else if (other.gameObject.CompareTag("Noscore") && count == 0)
        {
            
            count = 1;
            Score0.gameObject.SetActive(true);
            Invoke("Score0close", 1f);
        }
        
    }

    void Score100close()
    {
        Score100.gameObject.SetActive(false);
    }

    void Score30close()
    {
        Score30.gameObject.SetActive(false);
    }
    void Score0close()
    {
        Score0.gameObject.SetActive(false);
    }
}
