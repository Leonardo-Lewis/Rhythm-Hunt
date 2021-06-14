using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWeapon3 : MonoBehaviour
{
    public GameObject weaponObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Swing();
        }
    }

    private void Swing()
    {
        Instantiate(weaponObject, transform.position, transform.rotation);
    }
}
