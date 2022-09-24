using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Advanced touch input MonoBehaviour that spawns prefabs at touch positions.
public class AdvancedTouchInput : MonoBehaviour
{
    // Reference to touch count Text component in the scene.
    public TextMeshProUGUI touchCountText;

    // Reference to Prefabs in the project assets.
    public GameObject bananaPrefab;
    public GameObject blueberryPrefab;
    public GameObject watermelonPrefab;
    public GameObject grapePrefab;

    // Update method is called every frame, if the MonoBehaviour is enabled.
    private void Update()
    {
        // Display the current touch count in the Text component.
        touchCountText.text = "Touch count: " + Input.touchCount;

        // Make sure there are currently touches on the screen (at least one).
        if (Input.touchCount > 0)
        {
            // Obtain all the Touches currently available.
            for (int i = 0; i < Input.touchCount; i++)
            {
                // Get the Touch at index.
                Touch touch = Input.GetTouch(i);

                // Convert the screen position to world position.
                // A Z-coordinate ("10f") is passed to the method to account for offset from the Camera position.
                var worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10f));

                // Log the touch phase events.
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("TouchPhase.Began: " + i);
                    // Spawn a selected instance from the prefab each time the screen is touched.
                    switch(i)
                    {
                        case 0:
                            Instantiate(bananaPrefab, worldPosition, Quaternion.identity);
                            break;
                        case 1:
                            Instantiate(blueberryPrefab, worldPosition, Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(watermelonPrefab, worldPosition, Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(grapePrefab, worldPosition, Quaternion.identity);
                            break;
                    }
                }
            }
        }
    }
}