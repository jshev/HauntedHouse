using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPrompter : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {
        text.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{gameObject.name} collided with {collision.name}");

        if (collision.name != "Player")
            return;

        text.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"{gameObject.name} stopped colliding with {collision.name}");
        if (collision.name != "Player")
            return;

        text.gameObject.SetActive(false);
    }
}
