using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    private int jamur = 0;

    [SerializeField] private Text Jamur;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("jamur"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            jamur++;
            Jamur.text = "jamur :" + jamur;
        }
    }
}
