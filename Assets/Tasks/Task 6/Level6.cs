using UnityEngine;

public class Level6 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obstacle;
    
    private float _speed = 5;

    private void Start()
    {
        GameObject obstacleInstance = Instantiate(_obstacle);
    
        // Допишите следующую строку, чтобы уничтожить объект после создания
        Destroy(obstacleInstance,(float)0.5);
    }


    private void Update()
    {
        Destroy(_obstacle);
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition; 
    }
}