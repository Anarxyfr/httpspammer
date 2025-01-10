using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x02000002 RID: 2
[NullableContext(1)]
[Nullable(0)]
internal class Program
{
    // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
    [DebuggerStepThrough]
    private static Task Main(string[] args)
    {
        Program.< Main > d__2 < Main > d__ = new Program.< Main > d__2();

        < Main > d__.<> t__builder = AsyncTaskMethodBuilder.Create();

        < Main > d__.args = args;

        < Main > d__.<> 1__state = -1;

        < Main > d__.<> t__builder.Start < Program.< Main > d__2 > (ref < Main > d__);
        return < Main > d__.<> t__builder.Task;
    }

    // Token: 0x06000002 RID: 2 RVA: 0x00002094 File Offset: 0x00000294
    [DebuggerStepThrough]
    private static Task SendRequest(string url)
    {
        Program.< SendRequest > d__3 < SendRequest > d__ = new Program.< SendRequest > d__3();

        < SendRequest > d__.<> t__builder = AsyncTaskMethodBuilder.Create();

        < SendRequest > d__.url = url;

        < SendRequest > d__.<> 1__state = -1;

        < SendRequest > d__.<> t__builder.Start < Program.< SendRequest > d__3 > (ref < SendRequest > d__);
        return < SendRequest > d__.<> t__builder.Task;
    }

    // Token: 0x06000005 RID: 5 RVA: 0x000020F0 File Offset: 0x000002F0
    [DebuggerStepThrough]
    private static void <Main>(string[] args)
	{
		Program.Main(args).GetAwaiter().GetResult();
	}

	// Token: 0x04000001 RID: 1
	private const int ConcurrentRequests = 500;

    // Token: 0x04000002 RID: 2
    private static HttpClient _httpClient = new HttpClient();
}
