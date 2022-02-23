using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public GameObject StartCam;
    public GameObject[] cameras;
    move script3;
    // Start is called before the first frame update
    void Start()
    {
        script3 = GameObject.FindGameObjectWithTag("Player").GetComponent<move>();
        Invoke("startdelay", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        switch (script3.count)
        {
            case 1:
                cameras[1].SetActive(true);
                cameras[0].SetActive(false);
                break;
            case 2:
                cameras[2].SetActive(true);
                cameras[1].SetActive(false);
                break;
            case 3:
                cameras[3].SetActive(true);
                cameras[2].SetActive(false);
                break;
            case 4:
                cameras[4].SetActive(true);
                cameras[3].SetActive(false);
                break;
            case 5:
                cameras[5].SetActive(true);
                cameras[4].SetActive(false);
                break;
            case 6:
                cameras[6].SetActive(true);
                cameras[5].SetActive(false);
                break;
            case 7:
                cameras[7].SetActive(true);
                cameras[6].SetActive(false);
                break;
            case 8:
                cameras[8].SetActive(true);
                cameras[7].SetActive(false);
                break;
            case 9:
                cameras[9].SetActive(true);
                cameras[8].SetActive(false);
                break;
        }
    }

    void startdelay()
    {
        StartCam.SetActive(false);
        cameras[0].SetActive(true);
    }
}
