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


    //Limits the amount of times a player can use the "swing" command
    void Start()
    {
        canSwing = true;
        timePassed = 0.0f;
    }

    void Update()
    {
        //if statement that assigns different keys for different locations that the weapon object can be instantiated in
        if (Input.GetKeyDown(KeyCode.Q) && (canSwing == true))
        { 
            Swing(weaponSpawner1.transform.position);
            canSwing = false;
            //Prevents the object from  being instantiated again
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

        //every frame the timePassed value is increased based on Time.deltaTime
        timePassed += Time.deltaTime;

        //allows the weapon object to be instantiated again after a certain amount of time
        if (timePassed >= swingRate)
        {
            canSwing = true;
        }
    }

    //Siwng command that instantiates the object
    private void Swing(Vector3 swordPosition)
    {
       Instantiate(weaponObject, swordPosition, transform.rotation); 
    }
}
