using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject weaponObject;
    public KeyCode weaponKey;

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
        if (Input.GetKeyDown(weaponKey) && (canSwing == true))
        { 
            Swing();
            canSwing = false;
            timePassed = 0.0f;

        }

        timePassed += Time.deltaTime;

        if (timePassed >= swingRate)
        {
            canSwing = true;
        }
    }

    private void Swing()
    {
       Instantiate(weaponObject, transform.position, transform.rotation); 
    }
}
