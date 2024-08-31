using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacles"))
        {
            PlayerManager.gameOver = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gem"))
        {
            PlayerManager.gems++;
            Destroy(other.gameObject); 
        }
    }
}
