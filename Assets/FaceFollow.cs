using UnityEngine;

public class FaceFollow : MonoBehaviour
{
    public void FollowerFace(GameObject Player)
    {
        transform.position = new Vector3(Player.transform.position.x , Player.transform.position.y + 0.1f, transform.position.z);
    }
}
