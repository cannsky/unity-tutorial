using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public PlayerAnimation playerAnimation;
    public PlayerAttack playerAttack;
    public PlayerEquipment playerEquipment;
    public PlayerInputs playerInputs;
    public PlayerInventory playerInventory;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        Instance = this;
        playerAttack = new PlayerAttack();
        playerInputs = new PlayerInputs();
    }

    private void Start()
    {
        playerEquipment.OnStart();
        playerMovement.OnStart();
    }

    private void Update()
    {
        playerAttack.OnUpdate();
        playerInputs.OnUpdate();
        playerMovement.OnUpdate();
    }

    private void LateUpdate()
    {
        playerInputs.OnLateUpdate();
    }

}
