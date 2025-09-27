using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // En el eje x -7
        // En el eje z - 6
        transform.Translate(7.6f, 0.0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
