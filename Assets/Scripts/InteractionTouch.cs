using UnityEngine;

public class InteractionTouch : MonoBehaviour
{
    private Vector2 prevMousePos;
    private float rotationSpeed = 0.2f;
    private float zoomSpeed = 0.5f;
    private float minScale = 0.1f;
    private float maxScale = 5f;

    void Update()
    {
        // ======= TOUCH INPUT =======
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                RotateObject(touch.deltaPosition);
            }
        }
        else if (Input.touchCount == 2)
        {
            Touch t1 = Input.GetTouch(0);
            Touch t2 = Input.GetTouch(1);

            Vector2 prevT1 = t1.position - t1.deltaPosition;
            Vector2 prevT2 = t2.position - t2.deltaPosition;

            float prevDist = (prevT1 - prevT2).magnitude;
            float currDist = (t1.position - t2.position).magnitude;
            float delta = currDist - prevDist;

            ScaleObject(delta * 0.01f);
        }

        // ======= MOUSE INPUT =======
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            prevMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 delta = (Vector2)Input.mousePosition - prevMousePos;
            RotateObject(delta);
            prevMousePos = Input.mousePosition;
        }

        float scroll = Input.mouseScrollDelta.y;
        if (scroll != 0)
        {
            ScaleObject(scroll * zoomSpeed);
        }
#endif
    }

    void RotateObject(Vector2 delta)
    {
        float rotX = delta.y * rotationSpeed;
        float rotY = -delta.x * rotationSpeed;
        transform.Rotate(Vector3.up, rotY, Space.World);
        transform.Rotate(Vector3.right, rotX, Space.World);
    }

    void ScaleObject(float increment)
    {
        Vector3 newScale = transform.localScale + Vector3.one * increment;
        newScale = Vector3.Max(newScale, Vector3.one * minScale);
        newScale = Vector3.Min(newScale, Vector3.one * maxScale);
        transform.localScale = newScale;
    }
}