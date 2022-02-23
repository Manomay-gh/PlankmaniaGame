using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class overscore: MonoBehaviour
{
    public Text text;
    public float sharedscore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

        text.text=Scoremanager.score.ToString();
    }
}
