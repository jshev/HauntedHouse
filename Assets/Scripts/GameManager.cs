using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gameState = 0;
    public GameObject kidsDoor;
    public GameObject parentsDoor;
    public GameObject kitchenDoor;
    public GameObject utilityDoor;
    public GameObject garageDoor;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetGameState(int state)
    {
        gameState = state;
        switch (gameState)
        {
            case 0: // Game Start
                kidsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                parentsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                kitchenDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                utilityDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                garageDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case 1: // Investigating kid's room
                kidsDoor.transform.eulerAngles = new Vector3(0, 0, -90);
                parentsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                kitchenDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                utilityDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                garageDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case 2: // Investigating parents' room
                kidsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                parentsDoor.transform.eulerAngles = new Vector3(0, 0, -90);
                kitchenDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                utilityDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                garageDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case 3: //Investigating kitchen
                kidsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                parentsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                kitchenDoor.transform.eulerAngles = new Vector3(0, 0, 90);
                utilityDoor.transform.eulerAngles = new Vector3(0, 0, -90);
                garageDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
            case 4: // Investigating garage
                kidsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                parentsDoor.transform.eulerAngles = new Vector3(0, 0, 0);
                kitchenDoor.transform.eulerAngles = new Vector3(0, 0, 90);
                utilityDoor.transform.eulerAngles = new Vector3(0, 0, -90);
                garageDoor.transform.eulerAngles = new Vector3(0, 0, -90);
                break;
        }
    }
}
