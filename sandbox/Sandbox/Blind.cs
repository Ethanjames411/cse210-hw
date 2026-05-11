using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox;

public class Blind
{
    public double _Width;
    public double _Height;
    public string _Color;

    public double GetArea()
    {
        return _Width * _Height;
    }
}
public class House
{
    public string _Owner = "";
    public Blind _Kitchen = new Blind();
    public Blind _LivingRoom = new Blind();
    public List<Blind> _Blinds = new List<Blind>();
}