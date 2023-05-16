using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;
    public GameObject player;
    public SpeedBoost speedBoost;
    public PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindObjectOfType<PlayerController>();
        speedBoost = GameObject.FindObjectOfType<SpeedBoost>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreDisplay.text = "Score: " + score;
    }

    public void ResetTheSpeed()
    {
        StartCoroutine(ResetSpeed());
    }

    public IEnumerator ResetSpeed()
    {
        yield return new WaitForSeconds(6);
        pc.moveSpeed = speedBoost.originalSpeed;
        
    }

}
