using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float zBoundary;

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime * Vector3.forward);        
        if (transform.position.z < zBoundary )
        {
            Destroy( gameObject );
        }
    }
}
