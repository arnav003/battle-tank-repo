using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankType tankType;
        public Material color;
    }

    public List<Tank> Tanks;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateTank(TankType tankType)
    {
        int tankTypeIndex = 0;

        if (tankType == TankType.GreenTank)
        {
            tankTypeIndex = 0;
        }
        else if (tankType == TankType.BlueTank)
        {
            tankTypeIndex = 1;
        }
        else if (tankType == TankType.RedTank)
        {
            tankTypeIndex = 2;
        }

        TankModel tankModel = new TankModel(Tanks[tankTypeIndex].movementSpeed, Tanks[tankTypeIndex].rotationSpeed, Tanks[tankTypeIndex].tankType, Tanks[tankTypeIndex].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
