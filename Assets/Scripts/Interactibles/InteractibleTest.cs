using UnityEngine;

public class InteractibleTest : MonoBehaviour, IInteractible
{
    GameObject player;
    [SerializeField] Collider2D area;

    private bool player_in_area = false;
    private GameObject[] overlaps;

    public void Interact()
    {
        Debug.Log("Going to teleport hte player, hide the hub, show the docs room and all that jazz");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player_in_area && Input.GetKeyDown(KeyCode.E)){
            Interact();
        }    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the area (you can use the "Player" tag)
        if (other.CompareTag("Player"))
        {
            player_in_area = true;
            player = other.gameObject; // Optionally store the reference to the player
        }
    }

    // Called when another collider exits the trigger
    private void OnTriggerExit2D(Collider2D other)
    {
        // If the player leaves the area, set the flag to false
        if (other.CompareTag("Player"))
        {
            player_in_area = false;
            player = null;
        }
    }

}
