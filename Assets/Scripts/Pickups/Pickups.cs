using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickups : MonoBehaviour
{
    public PlayerController player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject.GetComponent<PlayerController>();
            ActivatePickUp();
            Destroy(gameObject);
        }
    }

    public virtual void ActivatePickUp()
    {

    }

}
