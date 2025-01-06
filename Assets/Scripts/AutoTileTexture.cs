using UnityEngine;

[ExecuteAlways] // Ensures this script runs in both Play Mode and Edit Mode
[RequireComponent(typeof(Renderer))]
public class AutoTileTexture : MonoBehaviour
{
    public Vector2 tileSize = Vector2.one; // Scale multiplier for tiling

    private void UpdateTiling()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.sharedMaterial != null)
        {
            Vector3 scale = transform.localScale;

            // Map the texture scaling to X and Z dimensions
            renderer.sharedMaterial.mainTextureScale = new Vector2(
                scale.x * tileSize.x,
                scale.z * tileSize.y // Use Z for the vertical tiling
            );
        }
    }

    // Called whenever a value is changed in the Inspector in Edit Mode
    private void OnValidate()
    {
        UpdateTiling();
    }

    // Ensures the tiling is updated in both Play Mode and Edit Mode
    private void Update()
    {
        if (!Application.isPlaying)
        {
            UpdateTiling();
        }
    }
}