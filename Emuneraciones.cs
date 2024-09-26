using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

public static class TipoMenu 
{
    public const short ADD = 1;
    public const short REMOVE = 2;
    public const short LIST = 3;
    public const short EXIST = 4;
    public static List<short> All = [ADD, REMOVE, LIST, EXIST];
}