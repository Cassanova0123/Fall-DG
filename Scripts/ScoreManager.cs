using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    private int initialEnergy = 100; // Barre d’énergie initiale
    private int currentEnergy;
    private int collisions;
    private int wallsDestroyed;
    private int totalWalls;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persiste entre les scènes si nécessaire
        }
    }
    public void Initialize(int totalWalls)
    {
        this.totalWalls = totalWalls;
        this.currentEnergy = initialEnergy;
        this.collisions = 0;
        this.wallsDestroyed = 0;
        UpdateScoreDisplay(); // Met à jour l'affichage du score
    }
    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            // Affiche les informations mises à jour sur l'UI
            scoreText.text = $"Energy: {currentEnergy}\n" +
                             $"Collisions: {collisions}\n" +
                             $"Walls Remaining: {GetRemainingWalls()}\n" +
                             $"Final Score: {CalculateFinalScore()}";
        }
    }
    public void RegisterCollision()
    {
        collisions++;
        currentEnergy -= 100; // La perte de l'énergie à chaque collision
        if (currentEnergy < 0) currentEnergy = 0;
        UpdateScoreDisplay(); // Mise à jour de l'énergie perdu par les collisions
    }
    public void RegisterWallDestroyed()
    {
        wallsDestroyed++;
        UpdateScoreDisplay(); // La mise a jour du score à chaque qu'un mur est détruit
    }

    public int GetCurrentEnergy()
    {
        return currentEnergy;
    }

    public int GetCollisions()
    {
        return collisions;
    }

    public int GetRemainingWalls()
    {
        return totalWalls - wallsDestroyed;
    }
    public int CalculateFinalScore()
    {
        // Exemple : score sur l'energie restant, les murs détruits et les collisions
        return (currentEnergy * 2) - (collisions * 10) + (GetRemainingWalls() * 5);
    }
}
