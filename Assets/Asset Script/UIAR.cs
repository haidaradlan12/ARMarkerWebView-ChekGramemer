using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIAR : MonoBehaviour
{
    public RectTransform ocr1, ocr2, ocr3, ocr4, ocr5, button;
    // Start is called before the first frame update
    void Start()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Kembalibutton()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void O1()
    {
        ocr1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void O2()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void O3()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void O4()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        button.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void O5()
    {
        ocr1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr2.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr3.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr4.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        ocr5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        button.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
