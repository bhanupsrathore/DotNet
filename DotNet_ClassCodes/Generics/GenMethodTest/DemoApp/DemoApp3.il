
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
// MVID: {3B0A98F8-E636-4F82-B619-E24C8F885306}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0000024F81AA0000


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
  .method private hidebysig static !!T  Select<T>(int32 choice,
                                                  !!T first,
                                                  !!T second) cil managed
  {
    // Code size       21 (0x15)
    .maxstack  2
    .locals init (bool V_0,
             !!T V_1)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldc.i4.2
    IL_0003:  rem
    IL_0004:  ldc.i4.1
    IL_0005:  ceq
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  brfalse.s  IL_000f

    IL_000b:  ldarg.1
    IL_000c:  stloc.1
    IL_000d:  br.s       IL_0013

    IL_000f:  ldarg.2
    IL_0010:  stloc.1
    IL_0011:  br.s       IL_0013

    IL_0013:  ldloc.1
    IL_0014:  ret
  } // end of method Program::Select

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       93 (0x5d)
    .maxstack  3
    .locals init (bool V_0,
             int32 V_1,
             string V_2,
             float64 V_3)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldlen
    IL_0003:  ldc.i4.0
    IL_0004:  cgt.un
    IL_0006:  stloc.0
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_005c

    IL_000a:  nop
    IL_000b:  ldarg.0
    IL_000c:  ldc.i4.0
    IL_000d:  ldelem.ref
    IL_000e:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_0013:  stloc.1
    IL_0014:  ldloc.1
    IL_0015:  ldstr      "Monday"
    IL_001a:  ldstr      "Friday"
    IL_001f:  call       !!0 Program::Select<string>(int32,
                                                     !!0,
                                                     !!0)
    IL_0024:  stloc.2
    IL_0025:  ldstr      "Selected string = {0}"
    IL_002a:  ldloc.2
    IL_002b:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0030:  nop
    IL_0031:  ldloc.1
    IL_0032:  ldc.r8     4.5599999999999996
    IL_003b:  ldc.r8     6.54
    IL_0044:  call       !!0 Program::Select<float64>(int32,
                                                      !!0,
                                                      !!0)
    IL_0049:  stloc.3
    IL_004a:  ldstr      "Selected double = {0}"
    IL_004f:  ldloc.3
    IL_0050:  box        [System.Runtime]System.Double
    IL_0055:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_005a:  nop
    IL_005b:  nop
    IL_005c:  ret
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


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
