
using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform pointPrefab;

    void Awake ()
    {
        Transform point = Instantiate(pointPrefab);
        point.localPosition = Vector3.right;

        point = Instantiate(pointPrefab);           //don't need to declare var point again
        point.localPosition = Vector3.right * 2f;
    }

}
