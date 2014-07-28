using UnityEngine;

public class TrackObject : MonoBehaviour
{
    public Vector3 Offset = Vector3.zero;
    public Transform ObjectToTrack;

    void Update()
    {
        transform.position = ObjectToTrack.position + Offset;
    }
}