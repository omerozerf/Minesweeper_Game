﻿using System;
using MyGrid.Code;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class Unit : MonoBehaviour
    {
        private UnitState unitState;

        
        [SerializeField] private SpriteRenderer SpriteRenderer;

        public SpriteRenderer Mask => mask;
        [SerializeField] private SpriteRenderer mask;

        public SpriteRenderer Flag => flag;
        [SerializeField] private SpriteRenderer flag;

        public SpriteRenderer Mine => mine;
        [SerializeField] private SpriteRenderer mine;
        
        
        [SerializeField] private TextMeshPro text;
        [SerializeField] private TileController tileController;


        private void Start()
        {
            flag.enabled = false;
        }


        public void SetUnit(UnitState unitState)
        {
            this.unitState = unitState;

            SpriteRenderer.color = this.unitState == UnitState.Mine ? Color.red : Color.white;
            mine.enabled = this.unitState == UnitState.Mine;
        }


        public void UpdateText()
        {
            if (unitState == UnitState.Mine)
            {
                text.text = "";
            }

            else
            {
                var list = tileController.GetAllNeighbours();

                int count = 0;
                foreach (var item in list)
                {
                    Unit unit = item.GetComponent<Unit>();

                    if (unit.unitState == UnitState.Mine) count++;
                }

                string result = count > 0 ? count.ToString() : "";
                text.text = result;
            }
        }


        public void Open()
        {
            mask.enabled = false;
            
        }
    }
}