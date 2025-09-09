using UnityEngine;

public class moveMouse : MonoBehaviour
{
    private GameObject sphere;
    public float planeY = 0f;  // height you want the sphere to stay on

    void Start()
    {
        sphere = this.gameObject;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Creates a ray to the mouse from the camera
        Plane plane = new Plane(Vector3.up, new Vector3(0, planeY, 0)); // XZ plane at Y = planeY

        if (plane.Raycast(ray, out float distance))
        {
            Vector3 worldPosition = ray.GetPoint(distance);
            sphere.transform.position = worldPosition;//Moves the sphere to the ray of the mouse
        }
    }
}
