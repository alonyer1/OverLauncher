// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
Console.WriteLine("hello world!");
//string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
string path = "path.txt";
byte[] char1 = Encoding.ASCII.GetBytes("127.0.0.1 bnet-emu.fish");
byte[] char2 = Encoding.ASCII.GetBytes("127.0.0.1 bnet-emu.fish");
string[] buffer = File.ReadAllLines(path);
FileStream hosts = File.Open(path, FileMode.Append, FileAccess.Write);
if (!buffer.Contains(Encoding.ASCII.GetBytes("127.0.0.1 bnet-emu.fish")))
{
}

