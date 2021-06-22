using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastEnemy : MonoBehaviour
{

    //When the assigned object collides with the weapon object, this function loads the "Victory" scene in the project.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerWeapon")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
