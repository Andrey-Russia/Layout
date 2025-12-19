using UnityEngine;

public class LevelSpavner : MonoBehaviour
{
    public Level Prefab;
    public Transform SpawnPosition;
    public int LevelsCount = 20;
    public int LevelLock = 16;
    void Start()
    {
        for (int i = 1; i <= LevelsCount; i++)
        {
            int rnd = Random.Range(0, 3);
            bool isLocked = false;

            if(i >= LevelLock)
            {
                isLocked = true;
            }

            Instantiate(Prefab, SpawnPosition).Init(i,rnd,isLocked);
        }
    }
}
