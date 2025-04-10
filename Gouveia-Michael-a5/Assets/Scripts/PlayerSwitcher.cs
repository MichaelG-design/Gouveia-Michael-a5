using UnityEngine;

public class PlayerSwitcher : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;  // Referencing the sprite renderer
    [SerializeField] private Sprite[] skins;                // Array that holds each skin (3 of them)

    private int currentSkinIndex = 0;                        // Keep track of the current skin

    
    void Start()
    {
        if (skins.Length > 0 && spriteRenderer != null)
        {
            spriteRenderer.sprite = skins[currentSkinIndex];  // Set initial skin
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))  // Recognize the C key being pressed
        {
            // Change to the next skin in the array (cycling through)
            currentSkinIndex = (currentSkinIndex + 1) % skins.Length;
            spriteRenderer.sprite = skins[currentSkinIndex];  // Update sprite to the new skin
        }
    }
}
