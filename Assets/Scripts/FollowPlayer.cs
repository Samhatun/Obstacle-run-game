using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   public Transform Cube;
   public Vector3 offset;
    
    void Update()
    {
        transform.position = Cube.position + offset;
    }
}
