using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Victorytext,playscore,endscore;
    public Button PlayagainBut,nextlevelBut,exitbut;
    public Image instruction,blackscreenTop;
    public GameObject blackscreen;

    public move move;
    void Start()
    {
        Invoke("UIStart", 0f);

        instruction.gameObject.SetActive(true);
        Invoke("stopinstruct", 5f);

    }

    // Update is called once per frame
    void Update()
    {
        if(move.end==true)
        {


            Invoke("UIEnd", 0f);

        }
    }

    void stopinstruct()
    {
        instruction.gameObject.SetActive(false);
    }

    void UIStart()
    {
        Victorytext.gameObject.SetActive(false);
        endscore.gameObject.SetActive(false);
        PlayagainBut.gameObject.SetActive(false);
        nextlevelBut.gameObject.SetActive(false);
        exitbut.gameObject.SetActive(false);
        playscore.gameObject.SetActive(true);
        blackscreen.gameObject.SetActive(false);
    }

    void UIEnd()
    {
        playscore.gameObject.SetActive(false);
        blackscreenTop.gameObject.SetActive(false);
        Victorytext.gameObject.SetActive(true);
        endscore.gameObject.SetActive(true);
        PlayagainBut.gameObject.SetActive(true);
        nextlevelBut.gameObject.SetActive(true);
        exitbut.gameObject.SetActive(true);
        blackscreen.gameObject.SetActive(true);
    }
}
