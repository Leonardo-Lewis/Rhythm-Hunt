using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public float numberOfLives;
    public GameObject heart3; 
    public GameObject heart2;


    //sets the number of lives at the start pf the game
    void Start()
    {
        numberOfLives = 3;
    }


    // Update is called once per frame

    //Every frame the game checks the number of lives, removing certain objects or loading the "Game Over" scene based on the number of lives
    void Update()
    {
        if (numberOfLives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if(numberOfLives == 2)
        {
            heart3.gameObject.SetActive(false);
        }
        if (numberOfLives == 1)
        {
            heart2.gameObject.SetActive(false);
        }
    }

    //subtracts from the number of lives when colliding with an object tagged "Enemy."
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            numberOfLives += -1;
        }
    }
}
