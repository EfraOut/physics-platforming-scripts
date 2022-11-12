using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class manaeges respawning the player after it touches an object with this script.
public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
        }
        
    }
}
