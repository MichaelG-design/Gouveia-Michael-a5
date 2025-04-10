using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject playerShip; // Reference to the PlayerShip GameObject

    private Player playerScript;  // Reference to the Player script

    private float teleportCooldown = 1f; // 1 second cooldown
    private float lastTeleportTime = -Mathf.Infinity; // Time of last teleport

    void Start()
    {
        playerScript = playerShip.GetComponent<Player>();
    }

    void Update()
    {
        // Only teleport if cooldown has passed
        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time >= lastTeleportTime + teleportCooldown)
        {
            Teleport();
            lastTeleportTime = Time.time;
        }
    }

    void Teleport()
    {
        Vector3 direction = playerShip.transform.up;
        playerShip.transform.position += direction * 5f;
    }
}
