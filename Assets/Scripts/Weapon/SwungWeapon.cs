using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    public float swingSpeed; // how fast i swing
    public float swingDeg; // how far i swing
    public override void Attack()
    {
        //Start Atk cooldown
        Invoke("AttackReset", 60f / attackRate);
        //Rotate to starting pos
        transform.localEulerAngles = new Vector3(0, 0, -swingDeg);
        //Turn On weapon
        EnableWeapon();
        //Swing down
        StartCoroutine(Swing());
        //Disable weapon (in the swing)
        
    }
    //Write a swinging coroutine
    IEnumerator Swing()
    {
        float degrees = 0f;
        while (degrees < swingDeg*2)
        {

            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        DisableWeapon();
    }
    
}
