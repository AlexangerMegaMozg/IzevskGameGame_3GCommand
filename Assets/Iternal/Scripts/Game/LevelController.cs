using UnityEngine;
using System;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;

    private int _playersCount;
    public float _beerCost { get; private set; }
    public float _beerEnergy { get; private set; }
    public float _vodkaCost { get; private set; }
    public float _vodkaEnergy { get; private set; }
    public float _vodkaEnergyInterval { get; private set; }
    public bool BeerChosed { get; private set; }

    private void LevelStarted () {
        var levelNum = GameVariables.Instance.LevelNumber;

        _playersCount = (int) levelNum / 10;
        _beerCost = 0.1f;
        _beerEnergy = 0.4f;
        _vodkaCost = 0.01f;
        _vodkaEnergy = 0.4f;
    }
    public void GetDrink (out float cost, out float energy) {
        if (BeerChosed)
        {
            cost = _beerCost;
            energy = _beerEnergy;
        }
        else
        {
            cost = _vodkaCost;
            energy = _vodkaEnergy + UnityEngine.Random.Range(-_vodkaEnergyInterval, _vodkaEnergyInterval);
        }
    }

    private void Start () {
        Instance = this;
    }
}