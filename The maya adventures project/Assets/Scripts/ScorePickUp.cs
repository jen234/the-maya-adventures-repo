using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    // Public Variable
    public int pickupValue = 1;

    void OnTriggerEnter(Collider other)
    {
        // Check if score script is attached to the thing we bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            scoreScript.AddScore(pickupValue);

            // We should then delete this object so we don't keep adding score
            Destroy(gameObject);
        }
    }
}
