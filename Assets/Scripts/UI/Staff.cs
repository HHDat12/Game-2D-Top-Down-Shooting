using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour, IWeapon
{
    [SerializeField] private WeaponInfo weaponInfo;
    [SerializeField] private GameObject magicLaser;
    [SerializeField] private Transform magicLaserSpawnPoint;

    private Animator animator;

    readonly int ATTACK_HASH = Animator.StringToHash("Attack");

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger(ATTACK_HASH);
    }

    public void SpawnStaffProjectileAnimEvent()
    {
        GameObject newLaser = Instantiate(magicLaser, magicLaserSpawnPoint.position, Quaternion.identity);
        newLaser.GetComponent<MagicLaser>().UpdateLaserRange(weaponInfo.weaponRange);
    }


    public WeaponInfo GetWeaponInfo()
    {
        return weaponInfo;
    }

}
