using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public float numberOfLives;
    public GameObject heart3; 
    public GameObject heart2;

    // Start is called before the first frame update
    void Start()
    {
        numberOfLives = 3;
    }

    // Update is called once per frame
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            numberOfLives += -1;
        }
    }
}
