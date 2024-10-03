using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTwin : MonoBehaviour
{
    [SerializeField]
    float sizeToScale = 2f;
   
    [SerializeField]
    float durationAnim = 0.7f;

    [SerializeField]
    float finalYPos = 0.5f;

    void Start()
    {
        LeanTween.moveLocalY(gameObject, 0.5f, durationAnim).setEase(LeanTweenType.easeInOutElastic);
        //LeanTween.scale(gameObject,Vector3.one * sizeToScale )
    }
}
