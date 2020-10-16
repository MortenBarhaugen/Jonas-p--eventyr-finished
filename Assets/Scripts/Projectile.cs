using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 velocity = new Vector2(0.0f, 0.0f); // Hastigheten og retningen til et gitt projektil.

    public GameObject FRPEnemiePrefab;

    private void Update()
    {
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y); //
        Vector2 newPosition = currentPosition + velocity * Time.deltaTime; //

        Debug.DrawLine(currentPosition, newPosition, Color.red);

        RaycastHit2D[] hits = Physics2D.LinecastAll(currentPosition, newPosition); // lager en linje mellom to punkt og ser om det er en collider der
        foreach (RaycastHit2D hit in hits)
        {
            Debug.Log(hit.collider.gameObject);
        }

        transform.position = newPosition; // currentPosition blir til denne
        
    }
}
