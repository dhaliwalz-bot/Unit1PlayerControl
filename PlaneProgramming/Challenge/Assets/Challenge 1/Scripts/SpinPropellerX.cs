using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 1000.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}
