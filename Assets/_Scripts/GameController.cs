﻿using System;
using System.Collections.Generic;
using MyGrid.Code;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }


        [SerializeField] private int mineAmount;
        

        private List<Unit> unitList = new List<Unit>();


        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("There is more than Game Manager!" + transform + "-" + Instance);
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }


        private void Start()
        {
            StartGame();
        }

        
        private void StartGame()
        {
            foreach (var tile in GridManager.Instance.Tiles)
            {
                Unit unit = tile.GetComponent<Unit>();
                unitList.Add(unit);
            }

            
            var list = new List<Unit>(unitList);

            for (int i = 0; i < mineAmount; i++)
            {
                var index = Random.Range(0, list.Count);
                var unit = list[index];

                unit.SetUnit(UnitState.Mine);
                list.RemoveAt(index);
            }


            foreach (var unit in unitList)
            {
                unit.UpdateText();
            }
        }


        public int GetMineAmount()
        {
            return mineAmount;
        }
    }
}