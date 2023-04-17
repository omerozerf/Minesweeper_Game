using System.Collections.Generic;
using MyGrid.Code;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance { get; private set; }


        [SerializeField] private int mineAmount;
        [SerializeField] private TextMeshProUGUI winScreen;
        

        private List<Unit> unitList = new List<Unit>();
        private bool isTouchMine;


        public bool isGameWin;
        public bool isFinish;
        

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


        public void StartGame()
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
                unit.isBomb = true;
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


        public void TouchMine()
        {
            if (isTouchMine) return;
            isTouchMine = true;
            
            foreach (var unit in unitList)
            {
                if (unit.unitState == UnitState.Mine)
                {
                    unit.Open();
                }
            }
            
            SoundManager.Instance.OnClickBomb();
            ParticleManager.Instance.TriggerParticleEffect();
            

            isFinish = true;
        }


        public void SetMineAmount(int mineAmount)
        {
            this.mineAmount = mineAmount;
        }


        public void GameWin()
        {
            int counter = 0;
            foreach (var tile in GridManager.Instance.Tiles)
            {
                Unit unit = tile.GetComponent<Unit>();
                if (unit.unitState != UnitState.Mine && !unit.Mask.enabled)
                {
                    counter++;
                }

                if (GridManager.Instance.Tiles.Count - mineAmount == counter)
                {
                    winScreen.color = Color.green;
                    winScreen.gameObject.SetActive(true);
                    isGameWin = true;
                }
            }
        }
    }
}