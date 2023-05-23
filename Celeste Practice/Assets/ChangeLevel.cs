using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] private GameObject VirtualCamera;
    [SerializeField] private GameObject Player;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            VirtualCamera.SetActive(true);
            Player.transform.position = new Vector3(-26, -39, 0);
        }
    }

}
