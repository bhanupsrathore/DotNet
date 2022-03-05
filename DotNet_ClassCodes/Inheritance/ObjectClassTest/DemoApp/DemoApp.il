
//  Microsoft (R) .NET IL Disassembler.  Version 6.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 6:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 6:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 36 2E 30 01 00 54 0E 14   // ersion=v6.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {D02035C4-D8D5-43E2-8A22-F8B90C7338FC}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x00000240A1440000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Interval
       extends [System.Runtime]System.Object
{
  .field private initonly int32 '<Minutes>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private initonly int32 '<Seconds>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Minutes() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Minutes>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Minutes

  .method public hidebysig specialname instance int32 
          get_Seconds() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Seconds>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Seconds

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 min,
                               int32 sec) cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  ldarg.2
    IL_000b:  ldc.i4.s   60
    IL_000d:  div
    IL_000e:  add
    IL_000f:  stfld      int32 Interval::'<Minutes>k__BackingField'
    IL_0014:  ldarg.0
    IL_0015:  ldarg.2
    IL_0016:  ldc.i4.s   60
    IL_0018:  rem
    IL_0019:  stfld      int32 Interval::'<Seconds>k__BackingField'
    IL_001e:  ret
  } // end of method Interval::.ctor

  .method public hidebysig instance int32 
          Time() cil managed
  {
    // Code size       22 (0x16)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldc.i4.s   60
    IL_0003:  ldarg.0
    IL_0004:  call       instance int32 Interval::get_Minutes()
    IL_0009:  mul
    IL_000a:  ldarg.0
    IL_000b:  call       instance int32 Interval::get_Seconds()
    IL_0010:  add
    IL_0011:  stloc.0
    IL_0012:  br.s       IL_0014

    IL_0014:  ldloc.0
    IL_0015:  ret
  } // end of method Interval::Time

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       38 (0x26)
    .maxstack  3
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "{0}:{1:00}"
    IL_0006:  ldarg.0
    IL_0007:  call       instance int32 Interval::get_Minutes()
    IL_000c:  box        [System.Runtime]System.Int32
    IL_0011:  ldarg.0
    IL_0012:  call       instance int32 Interval::get_Seconds()
    IL_0017:  box        [System.Runtime]System.Int32
    IL_001c:  call       string [System.Runtime]System.String::Format(string,
                                                                      object,
                                                                      object)
    IL_0021:  stloc.0
    IL_0022:  br.s       IL_0024

    IL_0024:  ldloc.0
    IL_0025:  ret
  } // end of method Interval::ToString

  .method public hidebysig virtual instance int32 
          GetHashCode() cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance int32 Interval::get_Minutes()
    IL_0007:  ldarg.0
    IL_0008:  call       instance int32 Interval::get_Seconds()
    IL_000d:  add
    IL_000e:  stloc.0
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.0
    IL_0012:  ret
  } // end of method Interval::GetHashCode

  .method public hidebysig virtual instance bool 
          Equals(object other) cil managed
  {
    // Code size       56 (0x38)
    .maxstack  2
    .locals init (class Interval V_0,
             bool V_1,
             bool V_2)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  isinst     Interval
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  ldnull
    IL_000a:  cgt.un
    IL_000c:  stloc.1
    IL_000d:  ldloc.1
    IL_000e:  brfalse.s  IL_0032

    IL_0010:  ldarg.0
    IL_0011:  call       instance int32 Interval::get_Minutes()
    IL_0016:  ldloc.0
    IL_0017:  callvirt   instance int32 Interval::get_Minutes()
    IL_001c:  bne.un.s   IL_002e

    IL_001e:  ldarg.0
    IL_001f:  call       instance int32 Interval::get_Seconds()
    IL_0024:  ldloc.0
    IL_0025:  callvirt   instance int32 Interval::get_Seconds()
    IL_002a:  ceq
    IL_002c:  br.s       IL_002f

    IL_002e:  ldc.i4.0
    IL_002f:  stloc.2
    IL_0030:  br.s       IL_0036

    IL_0032:  ldc.i4.0
    IL_0033:  stloc.2
    IL_0034:  br.s       IL_0036

    IL_0036:  ldloc.2
    IL_0037:  ret
  } // end of method Interval::Equals

  .property instance callconv(8) int32 Minutes()
  {
    .get instance int32 Interval::get_Minutes()
  } // end of property Interval::Minutes
  .property instance callconv(8) int32 Seconds()
  {
    .get instance int32 Interval::get_Seconds()
  } // end of property Interval::Seconds
} // end of class Interval

.class private auto ansi beforefieldinit Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  PrintInfo(string label,
                                                   object source) cil managed
  {
    // Code size       20 (0x14)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "{0} = {1}"
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  callvirt   instance string [System.Runtime]System.Object::ToString()
    IL_000d:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object,
                                                                        object)
    IL_0012:  nop
    IL_0013:  ret
  } // end of method Program::PrintInfo

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       321 (0x141)
    .maxstack  3
    .locals init (class Interval V_0,
             class Interval V_1,
             class Interval V_2,
             class Interval V_3,
             bool V_4,
             valuetype Rectangle V_5)
    IL_0000:  nop
    IL_0001:  ldc.i4.4
    IL_0002:  ldc.i4.s   15
    IL_0004:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0009:  stloc.0
    IL_000a:  ldc.i4.6
    IL_000b:  ldc.i4.s   50
    IL_000d:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0012:  stloc.1
    IL_0013:  ldc.i4.3
    IL_0014:  ldc.i4.s   75
    IL_0016:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_001b:  stloc.2
    IL_001c:  ldloc.1
    IL_001d:  stloc.3
    IL_001e:  ldstr      "Interval a"
    IL_0023:  ldloc.0
    IL_0024:  call       void Program::PrintInfo(string,
                                                 object)
    IL_0029:  nop
    IL_002a:  ldstr      "Interval b"
    IL_002f:  ldloc.1
    IL_0030:  call       void Program::PrintInfo(string,
                                                 object)
    IL_0035:  nop
    IL_0036:  ldstr      "Interval c"
    IL_003b:  ldloc.2
    IL_003c:  call       void Program::PrintInfo(string,
                                                 object)
    IL_0041:  nop
    IL_0042:  ldstr      "Interval d"
    IL_0047:  ldloc.3
    IL_0048:  call       void Program::PrintInfo(string,
                                                 object)
    IL_004d:  nop
    IL_004e:  ldstr      "a is identical to b: {0}"
    IL_0053:  ldloc.0
    IL_0054:  ldloc.1
    IL_0055:  ceq
    IL_0057:  box        [System.Runtime]System.Boolean
    IL_005c:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0061:  nop
    IL_0062:  ldstr      "a is identical to c: {0}"
    IL_0067:  ldloc.0
    IL_0068:  ldloc.2
    IL_0069:  ceq
    IL_006b:  box        [System.Runtime]System.Boolean
    IL_0070:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0075:  nop
    IL_0076:  ldstr      "d is identical to b: {0}"
    IL_007b:  ldloc.3
    IL_007c:  ldloc.1
    IL_007d:  ceq
    IL_007f:  box        [System.Runtime]System.Boolean
    IL_0084:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0089:  nop
    IL_008a:  ldstr      "a is equal to b: {0}"
    IL_008f:  ldloc.0
    IL_0090:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_0095:  ldloc.1
    IL_0096:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_009b:  bne.un.s   IL_00a6

    IL_009d:  ldloc.0
    IL_009e:  ldloc.1
    IL_009f:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_00a4:  br.s       IL_00a7

    IL_00a6:  ldc.i4.0
    IL_00a7:  box        [System.Runtime]System.Boolean
    IL_00ac:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00b1:  nop
    IL_00b2:  ldstr      "a is equal to c: {0}"
    IL_00b7:  ldloc.0
    IL_00b8:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00bd:  ldloc.2
    IL_00be:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00c3:  bne.un.s   IL_00ce

    IL_00c5:  ldloc.0
    IL_00c6:  ldloc.2
    IL_00c7:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_00cc:  br.s       IL_00cf

    IL_00ce:  ldc.i4.0
    IL_00cf:  box        [System.Runtime]System.Boolean
    IL_00d4:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00d9:  nop
    IL_00da:  ldstr      "d is equal to b: {0}"
    IL_00df:  ldloc.3
    IL_00e0:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00e5:  ldloc.1
    IL_00e6:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00eb:  bne.un.s   IL_00f6

    IL_00ed:  ldloc.3
    IL_00ee:  ldloc.1
    IL_00ef:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_00f4:  br.s       IL_00f7

    IL_00f6:  ldc.i4.0
    IL_00f7:  box        [System.Runtime]System.Boolean
    IL_00fc:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0101:  nop
    IL_0102:  ldarg.0
    IL_0103:  ldlen
    IL_0104:  conv.i4
    IL_0105:  ldc.i4.1
    IL_0106:  cgt
    IL_0108:  stloc.s    V_4
    IL_010a:  ldloc.s    V_4
    IL_010c:  brfalse.s  IL_0140

    IL_010e:  nop
    IL_010f:  ldloca.s   V_5
    IL_0111:  ldarg.0
    IL_0112:  ldc.i4.0
    IL_0113:  ldelem.ref
    IL_0114:  call       float32 [System.Runtime]System.Single::Parse(string)
    IL_0119:  stfld      float32 Rectangle::Length
    IL_011e:  ldloca.s   V_5
    IL_0120:  ldarg.0
    IL_0121:  ldc.i4.1
    IL_0122:  ldelem.ref
    IL_0123:  call       float32 [System.Runtime]System.Single::Parse(string)
    IL_0128:  stfld      float32 Rectangle::Breadth
    IL_012d:  ldstr      "Your Rectangle"
    IL_0132:  ldloc.s    V_5
    IL_0134:  box        Rectangle
    IL_0139:  call       void Program::PrintInfo(string,
                                                 object)
    IL_013e:  nop
    IL_013f:  nop
    IL_0140:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Program

.class private sequential ansi sealed beforefieldinit Rectangle
       extends [System.Runtime]System.ValueType
{
  .field public float32 Length
  .field public float32 Breadth
  .method public hidebysig instance float64 
          Area() cil managed
  {
    // Code size       20 (0x14)
    .maxstack  2
    .locals init (float64 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      float32 Rectangle::Length
    IL_0007:  ldarg.0
    IL_0008:  ldfld      float32 Rectangle::Breadth
    IL_000d:  mul
    IL_000e:  conv.r8
    IL_000f:  stloc.0
    IL_0010:  br.s       IL_0012

    IL_0012:  ldloc.0
    IL_0013:  ret
  } // end of method Rectangle::Area

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       63 (0x3f)
    .maxstack  3
    .locals init (valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_0,
             string V_1)
    IL_0000:  nop
    IL_0001:  ldloca.s   V_0
    IL_0003:  ldc.i4.3
    IL_0004:  ldc.i4.2
    IL_0005:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32,
                                                                                                                               int32)
    IL_000a:  ldloca.s   V_0
    IL_000c:  ldarg.0
    IL_000d:  ldfld      float32 Rectangle::Length
    IL_0012:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float32>(!!0)
    IL_0017:  nop
    IL_0018:  ldloca.s   V_0
    IL_001a:  ldstr      " x "
    IL_001f:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0024:  nop
    IL_0025:  ldloca.s   V_0
    IL_0027:  ldarg.0
    IL_0028:  ldfld      float32 Rectangle::Breadth
    IL_002d:  call       instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<float32>(!!0)
    IL_0032:  nop
    IL_0033:  ldloca.s   V_0
    IL_0035:  call       instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_003a:  stloc.1
    IL_003b:  br.s       IL_003d

    IL_003d:  ldloc.1
    IL_003e:  ret
  } // end of method Rectangle::ToString

} // end of class Rectangle


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file DemoApp.res
