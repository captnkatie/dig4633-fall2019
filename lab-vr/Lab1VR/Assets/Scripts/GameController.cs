using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public bool isappleplaced1;
    public bool isappleplaced2;

    public GameObject winText;
    public GameObject directions;

    public void checkForVictory() {

        if(isappleplaced1 && isappleplaced2)
        {
            Debug.Log("You got em all captn");
            winText.SetActive(true);
            directions.SetActive(false);
        }
    }

    public void applewasplaced()
    {
        this.isappleplaced1 = true;
        Debug.Log("Apple is placed!");
        checkForVictory();
    }
    public void applewasplacedtwo()
    {
        this.isappleplaced2 = true;
        Debug.Log("Apple2 is placed!");
        checkForVictory();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
