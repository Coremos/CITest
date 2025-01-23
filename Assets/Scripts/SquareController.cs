using UnityEngine;

public class SquareController : MonoBehaviour
{
    private void Update()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}