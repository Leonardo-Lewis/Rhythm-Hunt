using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject weaponObject;
    public GameObject weaponSpawner1;
    public GameObject weaponSpawner2;
    public GameObject weaponSpawner3;

    public float swingRate;
    public float timePassed;
    public bool canSwing;

    void Start()
    {
        canSwing = true;
        timePassed = 0.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && (canSwing == true))
        { 
            Swing(weaponSpawner1.transform.position);
            canSwing = false;
            timePassed = 0.0f;

        }
        else if (Input.GetKeyDown(KeyCode.W) && (canSwing == true))
            {
                Swing(weaponSpawner2.transform.position);
                canSwing = false;
                timePassed = 0.0f;

            }
        else if (Input.GetKeyDown(KeyCode.E) && (canSwing == true))
            {
                Swing(weaponSpawner3.transform.position);
                canSwing = false;
                timePassed = 0.0f;

            }

        timePassed += Time.deltaTime;

        if (timePassed >= swingRate)
        {
            canSwing = true;
        }
    }

    private void Swing(Vector3 swordPosition)
    {
       Instantiate(weaponObject, swordPosition, transform.rotation); 
    }
}
