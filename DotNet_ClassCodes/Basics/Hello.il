.assembly Hello {}
.assembly extern System.Console {} //part of Microsoft.NETCore.App framework (BCL)

.method public static void Run()
{
	.entrypoint	//program execution begins with call to this method

	ldstr	"Hello World!" //load the string on evaluation (register) stack
	call	void [System.Console]System.Console::WriteLine(string)
	ret
}


