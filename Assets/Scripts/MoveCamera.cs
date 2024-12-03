using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        if (cameraPosition != null) 
        {
            transform.position = cameraPosition.position;
        }
    }
}



