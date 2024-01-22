using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSoal : MonoBehaviour
{
    private int A,B,C,D,E,Total;
    public GameObject A0, A1, A2, A3, A4, A5;

    void Update()
    {
        Total = (A + B + C + D + E);
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

    public void Kembali()
    {
        A = 0; B = 0; C = 0; D = 0; E = 0;
    }
}
