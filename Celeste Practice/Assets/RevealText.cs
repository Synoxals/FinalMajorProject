using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealText : MonoBehaviour
{
    public GameObject[] Texts;

    void Start()
    {
        for (int i = 0; i < Texts.Length; i++)
        {
            Texts[i].SetActive(true);
        }
    }
}
