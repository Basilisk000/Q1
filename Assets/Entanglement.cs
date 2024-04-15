using UnityEngine;
using System.Collections;

public class Entanglement : MonoBehaviour
{
    public float pullForce = 10f; // Force applied to pull the opponent towards the player
    public float duration = 5f;   // Duration of entanglement in seconds

    private GameObject player;
    private GameObject opponent;
    private bool isEntangled = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isEntangled)
        {
            player = other.gameObject;
            opponent = other.gameObject.GetComponent<PlayerMovment>().enemy;

            if (opponent != null)
            {
                StartCoroutine(Entangle());
            }
        }
    }



    IEnumerator Entangle()
    {
        isEntangled = true;

        // Temporary code to illustrate the effect of entanglement
        Debug.Log("Entanglement activated!");

        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            PullOpponent();
            yield return null;
        }

        // Temporary code to illustrate the effect of entanglement ending
        Debug.Log("Entanglement deactivated!");

        isEntangled = false;
    }

    void PullOpponent()
    {
        if (opponent != null && player != null)
        {
            Vector3 direction = player.transform.position - opponent.transform.position;
            opponent.GetComponent<Rigidbody>().AddForce(direction.normalized * pullForce, ForceMode.Force);
        }
    }
}
