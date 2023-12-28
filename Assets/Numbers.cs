using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Numbers : MonoBehaviour
{
    public int ilksayi, ikincisayi;
    void Start()
    {
        Bolunenler(ilksayi, ikincisayi);
    }
    void Bolunenler(int ilksayi , int ikincisayi)
    {
        ArrayList tumsayilar = new ArrayList();
        ArrayList ikiyebolunen = new ArrayList();
        ArrayList ucebolunen = new ArrayList();
        ArrayList dordebolunen = new ArrayList();
        ArrayList besebolunen = new ArrayList();

        for (int i = ilksayi; i < ikincisayi; i++)
        {
            tumsayilar.Add(i);
            if (i%2==0)
            {
                ikiyebolunen.Add(i);
            }
            if (i%3==0)
            {
                ucebolunen.Add(i);
            }
            if (i%4==0)
            {
                dordebolunen.Add(i);
            }
            if (i % 5 == 0)
            {
                besebolunen.Add(i);
            }
        }
        string liste1 = "";
        foreach (var Tumsay�lar in tumsayilar)
        {
            liste1 += "-" + Tumsay�lar;
        }
        Debug.Log("Tumsay�lar" + liste1);
        string liste2 = "";
        foreach (var ikiyeb�l�nenler in ikiyebolunen)
        {
            liste2 += "-" + ikiyeb�l�nenler;
        }
        Debug.Log("ikiyeb�l�nenler" + liste2);
        string liste3 = "";
        foreach (var ucebolunenler in ucebolunen)
        {
            liste3 += "-" + ucebolunenler;
        }
        Debug.Log("ucebolunenler" + liste3);
        string liste4 = "";
        foreach (var dordebulonenler in dordebolunen)
        {
            liste4 += "-" + dordebulonenler;
        }
        Debug.Log("dordebulonenler" + liste4);
        string liste5 = "";
        foreach (var besebulonenler in besebolunen)
        {
            liste5 += "-" + besebulonenler;
        }
        Debug.Log("besebulonenler" + liste5);
    }
}
