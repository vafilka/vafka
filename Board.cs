using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    [SerializeField] private GameObject _board;
    [SerializeField] private GameObject _transformForNumber;
    [SerializeField] private GameObject _randomGameObject;
    [SerializeField] private List<Number> _numbers;

    [SerializeField] private const int _sizeX = 6;
    [SerializeField] private const int _sizeY = 13;
    [SerializeField] private Transform[,] _zone = new Transform[_sizeX, _sizeY];
    System.Random rand = new System.Random();

    private void Awake()
    {
        LoadTransformForNumber();
    }
    public void LoadTransformForNumber()
    {
        for (int i = 0; i < _sizeX; i++)
        {
            for (int o = 0; o < _sizeY; o++)
            {
                Transform transform = Instantiate(_transformForNumber).transform;
                _zone[i, o] = transform;
            }
        }
    }
    public void LoadNumber()
    {
        for (int i = 0; i < _sizeX; i++)
        {
            for (int o = 0; o < _sizeY; o++)
            {
                 GameObject numberOnj = (Instantiate(_randomGameObject, _zone[i, o].position, Quaternion.identity, _board.transform));
                _numbers.Add(numberOnj.GetComponent<Number>());
            }
        }
    }

}
