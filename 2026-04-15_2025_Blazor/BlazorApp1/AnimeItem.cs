public class AnimeItem
{
    public int MalId { get; set; }
    public string? Title { get; set; }
    public string? ImageUrl { get; set; }
    public string? Synopsis { get; set; }
    public int? Episodes { get; set; }
    public string? Status { get; set; }
    public string WatchStatus { get; set; } = "";
    public string? Details { get; set; }
    public int Rating { get; set; }
    public bool ShowDetails { get; set; }
}

public class JikanSearchResponse
{
    public List<JikanAnime> Data { get; set; } = new();
}

public class JikanAnime
{
    public int Mal_id { get; set; }
    public string Title { get; set; } = "";
    public JikanImages? Images { get; set; }
    public string? Synopsis { get; set; }
    public int? Episodes { get; set; }
    public string? Status { get; set; }
}

public class JikanImages
{
    public JikanImage? Jpg { get; set; }
}

public class JikanImage
{
    public string? Image_url { get; set; }
}