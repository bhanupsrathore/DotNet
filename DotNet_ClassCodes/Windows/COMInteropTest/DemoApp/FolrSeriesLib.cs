using System.Runtime.InteropServices;

namespace FolrSeriesLib;

[Guid("4AEBB8DE-98E2-4352-ABAB-C264A66A4806")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
interface IReduceTerms
{
    double Reduce(double first, double second);
}

[Guid("64DCB5B5-4484-4C54-8A78-0D96FD84AF79")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
interface IGenerateTerms
{
    void Begin(double first, double second, double third);
    double Generate(int skip = 0);
    double Combine(int count, IReduceTerms? merge = null, double identity = 0);
}

[Guid("30139810-E57A-4D5F-AD38-36D36AB078C7")]
[ComImport]
class CommonSequence {}

