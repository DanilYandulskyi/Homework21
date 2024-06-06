using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField , Range(0, 100)] private float _speed;
    [SerializeField] private bool _isMoving = true;

    public void MovePosition(Vector2 direction)
    {
        transform.Translate(direction * (_speed * Time.deltaTime));
    }
}