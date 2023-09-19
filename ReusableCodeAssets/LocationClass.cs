public class Location
{
    private Vector3 position;
    private Vector3 rotation;
    float fov;

    public Location()
    {

    }

    public void RotateToLocation(Vector3 location)
    {
        float thetaX = Mathf.Acos(Vector3.Dot(new Vector2(location.y, location.z), new Vector2(rotation.y, rotation.z)));
        float thetaY = Mathf.Acos(Vector3.Dot(new Vector2(location.x, location.z), new Vector2(rotation.x, rotation.z)));
        float thetaZ = Mathf.Acos(Vector3.Dot(new Vector2(location.x, location.y), new Vector2(rotation.x, rotation.y)));

        float dotProduct = Vector3.Dot(location, position);
        float product = location.magnitude * position.magnitude;
        float theta = Mathf.Acos(dotProduct / product);
    }
}
