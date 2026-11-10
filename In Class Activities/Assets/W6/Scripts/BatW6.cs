using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public float speed = 2f;
    public Transform cat;
    private bool isChasing = false;

    

    void Update()
    {
        if (isChasing && cat != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                cat.position,
                speed * Time.deltaTime
            );
        }
    }

    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }
}
