using UnityEngine;

public class Enlarge : MonoBehaviour
{
    public float scaleIncrease = 0.2f;
    public float speedDecrease = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform player = collision.gameObject.transform;

            player.localScale += new Vector3(scaleIncrease, scaleIncrease, 0f);

            PlayerMovement movement = collision.gameObject.GetComponent<PlayerMovement>();

            if (movement != null)
            {
                movement.speed -= speedDecrease;

                if (movement.speed < 1f)
                {
                    movement.speed = 1f;
                }
            }

        }
    }
}