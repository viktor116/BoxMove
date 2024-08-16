using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform transform;
    public Text text;
    void Update()
    {
        text.text = transform.position.z.ToString("0");
    }
}
