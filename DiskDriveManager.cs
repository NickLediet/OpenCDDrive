using UnityEngine;
using CDROM;

public class DiskDriveManager : MonoBehaviour
{
    void Awake()
    {
      Commands.Eject();
    }

}
