using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    public float boostSpeed = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement movement = other.GetComponent<PlayerMovement>();

            if (movement != null)
            {
                movement.speed = boostSpeed;
                Debug.Log("Speed BOOST!");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement movement = other.GetComponent<PlayerMovement>();

            if (movement != null)
            {
                movement.speed = 5f; // vrati na normalno
                Debug.Log("Back to normal speed");
            }
        }
    }
}