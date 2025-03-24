using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OliviaController : MonoBehaviour
{
    public TMP_Text text;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Olivia collided with {collision.name}");

        if (collision.name != "Player")
            return;

        text.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"Olivia stopped colliding with {collision.name}");
        if (collision.name != "Player")
            return;

        text.gameObject.SetActive(false);
    }
}
