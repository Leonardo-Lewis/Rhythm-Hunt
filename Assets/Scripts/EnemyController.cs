using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public GameObject bloodSplatter;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    //Destroys the Game Object and spawns a particle system when colliding with objects marked "PLayer" or "Weapon"
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerWeapon")
        {
            Destroy(gameObject);
            Instantiate(bloodSplatter, transform.position, transform.rotation);
        }
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
