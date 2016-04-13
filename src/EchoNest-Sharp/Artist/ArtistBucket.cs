using System;
using System.ComponentModel;

namespace EchoNest.Artist
{
    [Flags]
    public enum ArtistBucket
    {
        [Description("biographies")]
        Biographies = 1,
        [Description("blogs")]
        Blogs = 2,
        [Description("doc_counts")]
        DocCounts = 4,
        [Description("familiarity")]
        Familiarity = 8,
        [Description("hotttnesss")]
        Hotttnesss = 16,
        [Description("images")]
        Images = 32,
        [Description("news")]
        News = 64,
        [Description("reviews")]
        Reviews = 128,
        [Description("songs")]
        Songs = 256,
        [Description("terms")]
        Terms = 512,
        [Description("urls")]
        Urls = 1024,
        [Description("video")]
        Video = 2048,
        [Description("audio")]
        Audio = 4096,
        [Description("years_active")]
        YearsActive = 8192,
        [Description("id:musicbrainz")]
        IdMusicBrainz = 16384,
        [Description("id:playme")]
        IdPlayme = 32768,
        [Description("id:7digital-US")]
        Id7digital = 65536,
        [Description("id:rdio-us-streaming")]
        IdRdioUsStreaming = 131072,
        [Description("id:facebook")]
        IdFacebook = 262144,
        [Description("artist_location")]
        ArtistLocation = 524288,
        [Description("id:spotify-WW")]
        IdSpotifyWw = 1048576,
        [Description("id:spotify")]
        IdSpotify = 2097152,
        [Description("discovery")]
        Discovery = 4194304,
        [Description("discovery_rank")]
        DiscoveryRank = 8388608,
        [Description("familiarity_rank")]
        FamiliarityRank = 16777216,
        [Description("genre")]
        Genre = 33554432,
        [Description("hotttnesss_rank")]
        HotttnesssRank = 67108864
    }
}