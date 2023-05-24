using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInText : MonoBehaviour
{
    [SerializeField] Animator anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("FadeIn");
        Destroy(this);
    }
}
