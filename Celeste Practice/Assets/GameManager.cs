using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameObject[] Texts; 
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Texts.Length; i++)
        {
            Texts[i].SetActive(false);
        }
    }
}
