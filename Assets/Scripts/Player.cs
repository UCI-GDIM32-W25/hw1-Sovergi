using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5;
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space))
            if (_numSeedsLeft > 0)
                PlantSeed();
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _numSeedsLeft--;
        _numSeedsPlanted++;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
