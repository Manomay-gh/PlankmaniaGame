using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text text;
    public float sharedscore;
    
    // Start is called before the first frame update
    void Start()
    {
        Scoremanager.score = 0;
    }

    // Update is called once per frame
    void Update()
    { 

        text.text=Scoremanager.score.ToString();
    }
}
