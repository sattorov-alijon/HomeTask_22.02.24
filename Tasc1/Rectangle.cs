namespace Tasc1;



public class Rectangle
{
public int  _width;
public int  _height;
public string _color;
 public int GetArea()
 {
    return _width*_height;
 }
 public int GetPerimetr()
 {
    return 2*(_width+_height);
 }
 public string GetInfo()
 {
    return $"Width : {_width}\nHeight : {_height}\nColor : {_color}";
 }
}
