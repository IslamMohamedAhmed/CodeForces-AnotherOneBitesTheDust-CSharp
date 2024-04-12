using static System.Console;
using static System.Convert;
using static System.Math;


long a, b, c;

string str = ReadLine();

var arr = str.Split(" ");

a = ToInt64(arr[0]);
b = ToInt64(arr[1]);
c = ToInt64(arr[2]);

if(a == b)
{
    WriteLine(a + b + c * 2);
}
else
{
    WriteLine(Min(a,b)*2 + c * 2 + 1);
}
