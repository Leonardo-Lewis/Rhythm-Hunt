using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public float numberOfLives;

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
            SceneManager.LoadScene(0);
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
