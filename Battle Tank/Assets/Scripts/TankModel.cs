using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankType tankType;
    public Material color;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public TankModel(float _movementSpeed, float _rotationSpeed, TankType _tankType, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _rotationSpeed;
        tankType = _tankType;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController =  _tankController;
    }
}
