using UnityEngine;
using System.Collections;

public class Observation : MonoBehaviour
{
    private GameObject opponent;
    private bool negating = false;
    private float negationDuration = 20f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !negating)
        {
            // Find the opponent's vehicle
            opponent = FindOpponent(other.gameObject);
            if (opponent != null)
            {
                // Start negating the opponent's power-up
                StartCoroutine(NegatePowerUps());
            }
        }
    }

    IEnumerator NegatePowerUps()
    {
        negating = true;

        // Temporary code to illustrate the effect of power-up negation
        Debug.Log("Negating opponent's power-ups!");

        // Negate opponent's power-ups
        PowerUp[] opponentPowerUps = opponent.GetComponents<PowerUp>();
        foreach (PowerUp powerUp in opponentPowerUps)
        {
            powerUp.Negate();
        }

        // Wait for the duration of negation
        yield return new WaitForSeconds(negationDuration);

        // Stop negating
        negating = false;

        // Temporary code to illustrate the end of power-up negation
        Debug.Log("Opponent's power-up negation ended!");
    }

    GameObject FindOpponent(GameObject currentPlayer)
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            if (player != currentPlayer)
            {
                return player;
            }
        }

        return null;
    }
}
