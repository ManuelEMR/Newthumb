using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleManager : MonoBehaviour {

    public GameObject blackHolePrefab;

    private GameObject _playerOneBlackHole;
    private GameObject _playerTwoBlackHole;

    // Use this for initialization
    void Start () {

        _playerOneBlackHole = Instantiate(blackHolePrefab);
        _playerTwoBlackHole = Instantiate(blackHolePrefab);

        _playerOneBlackHole.SetActive(false);
        _playerTwoBlackHole.SetActive(false);

        PlayerInput.OnPlayerOneTouchDown += PlacePlayerOneBlackHole;
        PlayerInput.OnPlayerTwoTouchDown += PlacePlayerTwoBlackHole;
    }

    void OnDestroy(){

        PlayerInput.OnPlayerOneTouchDown -= PlacePlayerOneBlackHole;
        PlayerInput.OnPlayerTwoTouchDown -= PlacePlayerTwoBlackHole;
    }

    void PlacePlayerOneBlackHole(Vector3 position){

        position.Set(position.x, position.y, 0);

        _playerOneBlackHole.SetActive(true);
        _playerOneBlackHole.transform.position = position;
    }

    void PlacePlayerTwoBlackHole(Vector3 position){

        position.Set(position.x, position.y, 0);

        _playerTwoBlackHole.SetActive(true);
        _playerTwoBlackHole.transform.position = position;
    }
}
