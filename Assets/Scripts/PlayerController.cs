using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private GameObject colliding = null;
    public GameManager gameManager;
    public GameObject canvas;
    public DialogueRunner dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.activeSelf == false)
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;

        if (Input.GetKey(KeyCode.E) && colliding != null)
        {
            if(colliding.tag == "Olivia")
            {
                //canvas.SetActive(true);
                dialogue.StartDialogue("LivingRoom");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = collision.gameObject;
        Debug.Log(collision.tag);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        colliding = null;
    }
}
