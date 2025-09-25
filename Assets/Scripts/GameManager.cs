using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject molePrefab;
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform[] holes;
    private float spawnInterval = 3f;
    private bool isPlaying = true;
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        StartCoroutine(SpawnEntities());
    }

    IEnumerator SpawnEntities()
    {
        while (isPlaying)
        {
            yield return new WaitForSeconds(spawnInterval);
            int holeIndex = Random.Range(0, holes.Length);
            Transform hole = holes[holeIndex];

            GameObject entityToSpawn;
            if(Random.value < 0.7f)
            {
                entityToSpawn = molePrefab;
            }
            else
            {
                entityToSpawn = bombPrefab;
            }
            GameObject spawned = Instantiate(entityToSpawn, hole.position, Quaternion.identity);
            Destroy(spawned, 1.5f); 

            if (spawnInterval > 0.5f)
                spawnInterval -= 0.01f;
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score; 
    }
}
