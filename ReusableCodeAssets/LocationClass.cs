public class Location
{
    private Vector3 position;
    private Vector3 rotation;
    float fov;

    public Location()
    {

    }

    public void rotateToLocation(Vector3 location)
    {
        float dotProduct = Vector3.Dot(location, position);
        float product = location.magnitude * position.magnitude;
        float theta = Mathf.Acos(dotProduct / product);
    }
}
