using UnityEngine;
using System.Collections;

public class DisappearingWallTrigger : MonoBehaviour
{
    [SerializeField] private GameObject wall;          
    [SerializeField] private float disappearDuration = 3f;  
    [SerializeField] private string interactionKey = "f";    

    private bool isOnCooldown = false;  
    private bool playerInZone = false;   

    private void Update()
    {
        if (playerInZone && Input.GetKeyDown(interactionKey) && !isOnCooldown)
        {
            StartCoroutine(TemporarilyDisappearWall());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = true;
            Debug.Log("Pritisni F ");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }

    private IEnumerator TemporarilyDisappearWall()
    {
        isOnCooldown = true;

        wall.SetActive(false);

        yield return new WaitForSeconds(disappearDuration);

        wall.SetActive(true);

        isOnCooldown = false;
    }
}