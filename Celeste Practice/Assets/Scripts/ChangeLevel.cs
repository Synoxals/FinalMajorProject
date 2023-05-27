using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] private GameObject VirtualCamera;
    [SerializeField] private GameObject Player;
    [SerializeField] private Vector3 PlayerPosition;
    [SerializeField] private GameObject[] Text;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player Collided");
            VirtualCamera.SetActive(true);
            Player.transform.position = PlayerPosition;
            for (int i = 0; i < Text.Length; i++)
            {
                Text[i].SetActive(false);
            }
        }
    }

}
