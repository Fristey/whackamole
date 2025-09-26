using UnityEngine;

public class BombScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.RemoveScore(1);
        Destroy(gameObject);
    }
}
