using UnityEngine;

public class Shrink : MonoBehaviour
{
    public float scaleDecrease = 0.2f;
    public float speedIncrease = 1f;
    public float minScale = 0.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform player = collision.gameObject.transform;

            Vector3 newScale = player.localScale - new Vector3(scaleDecrease, scaleDecrease, 0f);

            if (newScale.x < minScale)
            {
                newScale.x = minScale;
            }

            if (newScale.y < minScale)
            {
                newScale.y = minScale;
            }

            player.localScale = newScale;

            PlayerMovement movement = collision.gameObject.GetComponent<PlayerMovement>();

            if (movement != null)
            {
                movement.speed += speedIncrease;
            }

        }
    }
}