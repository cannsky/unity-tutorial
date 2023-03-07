using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MusicManager musicManager;

    public static GameManager Instance;

    private void Awake() => Instance = this;

    private void Start()
    {
        musicManager.Start();
    }

    private void Update()
    {
        musicManager.Update();
    }
}
