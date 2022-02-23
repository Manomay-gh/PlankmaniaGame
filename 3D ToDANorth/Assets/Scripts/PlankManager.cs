using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankManager : MonoBehaviour
{
    public GameObject[] Plank;
    move script2;
    // Start is called before the first frame update
    void Start()
    {
        script2 = GameObject.FindGameObjectWithTag("Player").GetComponent<move>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (script2.count)
        {
            case 1:
                Plank[0].SetActive(true);
                break;
            case 2:
                Plank[1].SetActive(true);
                break;
            case 3:
                Plank[2].SetActive(true);
                break;
            case 4:
                Plank[3].SetActive(true);
                break;
            case 5:
                Plank[4].SetActive(true);
                break;
            case 6:
                Plank[5].SetActive(true);
                break;
            case 7:
                Plank[6].SetActive(true);
                break;
            case 8:
                Plank[7].SetActive(true);
                break;

        }
    }
}
