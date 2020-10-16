using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitPlayer : MonoBehaviour
{
    public int playerHealth = 10;
    public int currentHealth;
    public int damageAmount = 1;
    public int maxHealth = 10;
    public bool alive;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //playerHealth = currentHealth - damageAmount;
            currentHealth -= damageAmount;
            //Debug.Log("Wow! ITS WORKS MAN OMG!!");
            if(currentHealth <= 0)
            {
                //Destroy(gameObject);
                alive = false;
                SceneManager.LoadScene("Game Over");
                //Debug.Log("You Died");
            }
        }
    }
}