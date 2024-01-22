using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMenu : MonoBehaviour
{
    public RectTransform PGKanan, PGKiri, PUtama, POtion, PCG, PMQ, PAU, PGO;
    // Start is called before the first frame update
    void Start()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Kembalibutton()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void OptionbuttonON()
    {
        POtion.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void OptionbuttonOFF()
    {
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void CGbutton()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MQbutton()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void AUbutton()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void GObutton()
    {
        PGKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGKanan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PUtama.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        POtion.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PCG.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PMQ.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PAU.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PGO.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
