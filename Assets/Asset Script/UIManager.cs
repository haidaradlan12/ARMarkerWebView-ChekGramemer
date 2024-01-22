using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MN1, MN2, Button, Info, MT, Konsul, Gambar1, Gambar2, Hasil, Soal1, Soal2, Soal3, Soal4, Soal5;    
    // Start is called before the first frame update
    void Start()
    {
        MN1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Kembalibutton()
    {
        MN1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Infobutton()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void MTbutton()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Konsulbutton()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal1button()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal2button()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal3button()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal4button()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal5button()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soalevaluasibutton()
    {
        MN1.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MN2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Info.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        MT.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Konsul.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Gambar1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Gambar2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
