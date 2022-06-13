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
        CreateTank();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateTank()
    {
        int i = 2; // green
        TankModel tankModel = new TankModel(Tanks[i].movementSpeed, Tanks[i].rotationSpeed, Tanks[i].tankType, Tanks[i].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
