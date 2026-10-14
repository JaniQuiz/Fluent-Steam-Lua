namespace SteamLuaManager.Models;

// 小黑盒热门榜单项：集合顺序即榜单名次
public sealed record RankGame(int AppId, string Name, string CoverUrl, List<string> CoverCandidates, long Followers)
{
    // 关注数过大时折成万单位展示
    public string FollowersText => Followers >= 10000 ? $"{Followers / 10000.0:F1}万关注" : $"{Followers}关注";

    // 卡片副标题：只显示关注数
    public string DisplaySubtitle => FollowersText;
}
