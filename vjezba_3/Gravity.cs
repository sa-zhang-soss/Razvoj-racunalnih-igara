using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.GetComponent<Rigidbody2D>() != null)
        {
            ToggleGravity();
        }
    }

    private void ToggleGravity()
    {

        float currentGravity = Physics2D.gravity.y;
        Physics2D.gravity = new Vector2(0, -currentGravity);

    }
}