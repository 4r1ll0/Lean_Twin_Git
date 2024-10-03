using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject popup;
    [SerializeField]
    float timeAnim;
    [SerializeField]
    LeanTweenType animCurve;

    void Start()
    {
        background.SetActive(false);
        popup.SetActive(false);
    }

    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            popup.SetActive(true);
            background.SetActive(true);
            LeanTween.moveLocalY(popup, -900f, 0f);
            LeanTween.moveLocalY(popup, 0f, timeAnim).setEase(animCurve);
        }
    }
}
