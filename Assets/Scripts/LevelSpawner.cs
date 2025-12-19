using UnityEngine;

public class LevelSpavner : MonoBehaviour
{
    [SerializeField] private Level _prefab;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private int _levelsCount = 20;
    [SerializeField] private int _levelLock = 16;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= _levelsCount; i++)
        {
            int rnd = Random.Range(0, 3);
            bool isLocked = false;

            //isLocked = i >= _levelLock;

            if(i >= _levelLock)
            {
                isLocked = true;
            }

            Instantiate(_prefab, _spawnPosition).Init(i,rnd,isLocked);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
