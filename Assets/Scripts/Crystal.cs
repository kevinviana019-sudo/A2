using UnityEngine;

public class Crystal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddCrystal(this);
            gameObject.SetActive(false);
        }
    }
}
