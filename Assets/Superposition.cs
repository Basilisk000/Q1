using UnityEngine;
using System.Collections;

public class Superposition : MonoBehaviour
{
    public float exchangeDuration = 2f; // Duration of position exchange in seconds

    private GameObject player;
    private GameObject opponent;
    private bool isExchangingPosition = false;


    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player") && !isExchangingPosition)
        {
            opponent = other.gameObject.GetComponent<PlayerMovment>().enemy;
            player = other.gameObject;

            if (opponent != null)
            {
                StartCoroutine(ExchangePosition());
            }
        }
    }

    

    IEnumerator ExchangePosition()
    {
        isExchangingPosition = true;

        // Temporary code to illustrate the effect of position exchange
        Debug.Log("Position exchange activated!");

        // Store initial positions
        Vector3 playerInitialPosition = player.transform.position;
        Vector3 opponentInitialPosition = opponent.transform.position;

        // Move player to opponent's position
        player.transform.position = opponentInitialPosition;

        // Move opponent to player's position
        opponent.transform.position = playerInitialPosition;

        yield return new WaitForSeconds(exchangeDuration);

        // Temporary code to illustrate the effect of position exchange ending
        Debug.Log("Position exchange deactivated!");

        isExchangingPosition = false;
    }
}
