using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float lifeTime;

    //destroys the weapon object after a certain amount of time
    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

}
