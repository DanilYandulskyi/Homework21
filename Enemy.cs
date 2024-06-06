using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private Mover _movement;
    private Vector3 _route;

    private void Awake()
    {
        _movement = GetComponent<Mover>(); 
    }

    private void Update()
    {
        _movement.MovePosition(_route);     
    }

    public void Initialize(Vector3 route)
    {
        _route = route;
    }
}
