using UnityEngine;

public class MoleScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.AddScore(1);
        Destroy(gameObject);
    }
}
