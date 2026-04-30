using UnityEngine;

public class Animator : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _rotationSpeed = 120F;
    [SerializeField] private Vector3 _rotationAxis = Vector3.up;

    private void Update()
    {
        transform.Rotate(_rotationAxis, _rotationSpeed * Time.deltaTime);
    }
}
