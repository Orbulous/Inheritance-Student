using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotPower : MonoBehaviour
{
    public SuperShot superShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            superShot.attackRate = 0.05f;
            Destroy(gameObject);
        }
    }
}
