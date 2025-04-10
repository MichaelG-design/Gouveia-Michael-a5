using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject playerShip; // Reference to the PlayerShip GameObject (the one with the Player script)

    private Player playerScript; // Reference to the Player script (the one you just shared)

    void Start()
    {
        // Get the Player script attached to the playerShip
        playerScript = playerShip.GetComponent<Player>();
    }

    void Update()
    {
        // Check if the "S" key is pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Teleport();
        }
    }

    void Teleport()
    {
        // Get the direction the player is facing (up direction of the transform)
        Vector3 direction = playerShip.transform.up;

        // Teleport the player by 5 units in the direction the player is facing
        playerShip.transform.position += direction * 5f;
    }
}
