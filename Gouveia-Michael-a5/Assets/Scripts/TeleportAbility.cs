using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject playerShip;
    public GameObject cooldownIndicator; 

    private Player playerScript;

    private float teleportCooldown = 1f;
    private float lastTeleportTime = -Mathf.Infinity;

    void Start()
    {
        playerScript = playerShip.GetComponent<Player>();
        cooldownIndicator.SetActive(false); // Hide at start
    }

    void Update()
    {
        bool canTeleport = Time.time >= lastTeleportTime + teleportCooldown;

        // Show or hide the indicator based on cooldown
        cooldownIndicator.SetActive(!canTeleport);

        // Check for teleport input
        if (Input.GetKeyDown(KeyCode.LeftShift) && canTeleport) //Teleports when 'LeftShift' is pressed
        {
            Teleport();
            lastTeleportTime = Time.time;
        }
    }

    void Teleport()
    {
        Vector3 direction = playerShip.transform.up;
        playerShip.transform.position += direction * 5f; //Teleports player 5 spaces in direction they are facing
    }
}
