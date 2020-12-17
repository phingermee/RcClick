using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rocket : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _score = 0;
    [SerializeField]private SpaceMan _man;
    [SerializeField] AudioClip _shot;
    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void SpawnMan()
    {
        Instantiate(_man);
    }

    private void OnMouseDown()
    {
        ScoreController.instance.ChangeScore(ref _scoreText);
        SpawnMan();
        _source.PlayOneShot(_shot);
    }
}
