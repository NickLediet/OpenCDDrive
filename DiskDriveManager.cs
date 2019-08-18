using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using CDROM;

public class DiskDriveManager : MonoBehaviour
{
    void Awake()
    {
      Commands.Eject();
    }

}
