using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UISoal : MonoBehaviour
{
    public RectTransform Level, Soal1, Soal2, Soal3, Soal4, Soal5, Jawaban;
    public GameObject S1, S2, S3, S4, S5;
    public GameObject Benar, Salah;
    private int A, B, C, D, E, Total;
    public GameObject A0, A1, A2, A3, A4, A5;
    int Apaya;
    // Start is called before the first frame update
    void Update()
    {
        Total = (A + B + C + D + E);
        if (Apaya == 1)
        {
            Benar.SetActive(true);
            Salah.SetActive(false);
        }
        else if (Apaya==0)
        {
            Benar.SetActive(false);
            Salah.SetActive(true);
        }
        else if (Apaya==3)
        {
            Benar.SetActive(false);
            Salah.SetActive(false);
            if (Total == 0)
            {
                A0.SetActive(true);
                A1.SetActive(false);
                A2.SetActive(false);
                A3.SetActive(false);
                A4.SetActive(false);
                A5.SetActive(false);
            }
            else if (Total == 1)
            {
                A0.SetActive(false);
                A1.SetActive(true);
                A2.SetActive(false);
                A3.SetActive(false);
                A4.SetActive(false);
                A5.SetActive(false);
            }
            else if (Total == 2)
            {
                A0.SetActive(false);
                A1.SetActive(false);
                A2.SetActive(true);
                A3.SetActive(false);
                A4.SetActive(false);
                A5.SetActive(false);
            }
            else if (Total == 3)
            {
                A0.SetActive(false);
                A1.SetActive(false);
                A2.SetActive(false);
                A3.SetActive(true);
                A4.SetActive(false);
                A5.SetActive(false);
            }
            else if (Total == 4)
            {
                A0.SetActive(false);
                A1.SetActive(false);
                A2.SetActive(false);
                A3.SetActive(false);
                A4.SetActive(true);
                A5.SetActive(false);
            }
            else if (Total == 5)
            {
                A0.SetActive(false);
                A1.SetActive(false);
                A2.SetActive(false);
                A3.SetActive(false);
                A4.SetActive(false);
                A5.SetActive(true);
            }
        }
    }
    void Start()
    {
        S1.SetActive(false);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        S5.SetActive(false);
        Soal1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Soal_1()
    {
        S1.SetActive(true);
        S2.SetActive(true);
        S3.SetActive(true);
        S4.SetActive(true);
        S5.SetActive(true);
        Level.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Soal_2()
    {
        Soal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Soal_3()
    {
        Soal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Soal_4()
    {
        Soal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void Soal_5()
    {
        Soal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void Pilihbutton()
    {
        Jawaban.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }
    public void Backbutton()
    {
        Jawaban.DOAnchorPos(new Vector2(0, -2500), 0.5f);
    }
    public void Jawab(int BenarSalah)
    {
        Apaya = BenarSalah;
    }

    public void soal1(int nilai)
    {
        A = nilai;
    }
    public void soal2(int nilai)
    {
        B = nilai;
    }
    public void soal3(int nilai)
    {
        C = nilai;
    }
    public void soal4(int nilai)
    {
        D = nilai;
    }
    public void soal5(int nilai)
    {
        E = nilai;
    }

    public void NilaiKeluar(int ini)
    {

    }
    public void Kembali()
    {
        S1.SetActive(false);
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        Level.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Jawaban.DOAnchorPos(new Vector2(0, -2500), 0.1f);
        A = 0; B = 0; C = 0; D = 0; E = 0;
        A0.SetActive(false);
        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A5.SetActive(false);
        Apaya = 2;
    }
    public void KembaliPertama()
    {
        S2.SetActive(false);
        S3.SetActive(false);
        S4.SetActive(false);
        S5.SetActive(false);
        Level.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        A = 0; B = 0; C = 0; D = 0; E = 0;
        A0.SetActive(false);
        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A5.SetActive(false);
        Apaya = 2;
    }

}
