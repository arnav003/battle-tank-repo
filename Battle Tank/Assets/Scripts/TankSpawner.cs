using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
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
        TankModel tankModel = new TankModel(20,30);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
