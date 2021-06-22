using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyType1 : MonoBehaviour
{
    public float speed;
    public GameObject bloodSplatter;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

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
