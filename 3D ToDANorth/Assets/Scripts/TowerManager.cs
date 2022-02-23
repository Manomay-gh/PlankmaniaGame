using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject[] Tower;
    move script;
    // Start is called before the first frame update
    void Start()
    {
       script = GameObject.FindGameObjectWithTag("Player").GetComponent<move>();
    }

    // Update is called once per frame
    void Update()
    {
       switch(script.count)
        {
            case 1 : Tower[0].SetActive(true);
                break;
            case 2:
                Tower[1].SetActive(true);
                break;
            case 3:
                Tower[2].SetActive(true);
                break;
            case 4:
                Tower[3].SetActive(true);
                break;
            case 5:
                Tower[4].SetActive(true);
                break;
            case 6:
                Tower[5].SetActive(true);
                break;
            case 7:
                Tower[6].SetActive(true);
                break;
            case 8:
                Tower[7].SetActive(true);
                break;
        }
    }
}
