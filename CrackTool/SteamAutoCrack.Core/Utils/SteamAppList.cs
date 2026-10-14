namespace SteamAutoCrack.Core.Utils;

// SQLite 游戏列表库的占位实现：DLC 名解析走商店接口直查，无需本地建库；
// 同名空壳让其它生成器照常编译，未命中时返回空名走回退分支
public class SteamApp
{
    public uint? AppId { get; set; }

    public string? Name { get; set; }

    public override string ToString()
    {
        return $"{AppId}={Name}";
    }
}

public class SteamAppList
{
    public static Task WaitForReady()
    {
        return Task.CompletedTask;
    }

    public static Task<SteamApp> GetAppById(uint appid)
    {
        return Task.FromResult(new SteamApp
        {
            AppId = appid,
            Name = null
        });
    }
}
