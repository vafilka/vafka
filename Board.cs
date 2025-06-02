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
    [SerializeField] private GameObject[,] _zone = new GameObject[_sizeX, _sizeY];
    System.Random rand = new System.Random();

    private void Awake()
    {
        LoadTransformForNumber();
        LoadNumber();
    }
    public void LoadTransformForNumber()
    {
        for (int i = 0; i < _sizeX; i++)
        {
            for (int o = 0; o < _sizeY; o++)
            {
                GameObject transform = Instantiate(_transformForNumber, _board.transform);
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
                 GameObject numberOnj = (Instantiate(_randomGameObject, _zone[i, o].transform.position, Quaternion.identity));
                _numbers.Add(numberOnj.GetComponent<Number>());
            }
        }
    }

}
