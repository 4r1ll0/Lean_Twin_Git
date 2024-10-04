using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (popup.activeSelf)
            {
                HidePopUp();
            }
            else
            {
                ShowPopUp();
            }
        }
    }

    //Funcion
    public void ShowPopUp()
    {
        popup.SetActive(true);
        background.SetActive(true);
        LeanTween.moveLocalY(popup, -900f, 0f);
        LeanTween.moveLocalY(popup, 0f, timeAnim).setEase(animCurve);
    }

    public void HidePopUp()
    {
        LeanTween.moveLocalY(popup, -900f, timeAnim).setEase(animCurve).setOnComplete(() => { 
        
            popup.SetActive(false);
        });
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, timeAnim).setOnComplete(() =>
        {
            background.SetActive(false);
            //poner el alpha canva a 1 , hacerlo en 0 segs
            LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f, 0f);
        });
    }

}
    


