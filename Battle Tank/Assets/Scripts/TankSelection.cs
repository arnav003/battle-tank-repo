using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }
}
