using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Pickups
{
    public GameManager gm;
    public float originalSpeed;
    // Start is called before the first frame update
    public override void ActivatePickUp()
    {
        originalSpeed = player.moveSpeed;

        player.moveSpeed *= 2.0f;
        GameObject.FindObjectOfType<GameManager>().ResetTheSpeed();

    }
}
