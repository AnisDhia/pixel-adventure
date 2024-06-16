using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int melons = 0;
    private int pineapples = 0;

    [SerializeField] private TextMeshProUGUI melonText;
    [SerializeField] private TextMeshProUGUI pineappleText;
    [SerializeField] private AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon")) {
            collectSound.Play();
            Destroy(collision.gameObject);
            melons++;
            melonText.text = "Melons: " + melons;
        } 
        
        if (collision.gameObject.CompareTag("Pineapple")) {
            collectSound.Play();
            Destroy(collision.gameObject);
            pineapples++;
            pineappleText.text = "Pineapples: " + pineapples;
        }
    }
}
