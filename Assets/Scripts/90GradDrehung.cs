using UnityEngine;

public class RotatePrefab : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        // Rotate the prefab 90 degrees on the X-axis
        transform.Rotate(Vector3.right * 90f * Time.deltaTime);
    }
}

