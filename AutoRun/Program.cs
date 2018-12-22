using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
namespace AutoRun
{
	class Program
	{
		static void Main(string[] args)
		{
			AutoItX.Run("notepad.exe", "");
			AutoItX.WinWaitActive("Untitled");
			AutoItX.Send("I'm in notepad");
			AutoItX.Sleep(10000);
			IntPtr winHandle = AutoItX.WinGetHandle("Untitled");
			AutoItX.WinKill(winHandle);
		}
	}
}
