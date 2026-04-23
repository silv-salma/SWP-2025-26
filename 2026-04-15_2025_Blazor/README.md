# Anime List Web Application

## Project Overview
- **Date**: April 23, 2026
- **Project Type**: Blazor Web Application (.NET 9)
- **API Used**: Jikan API (https://jikan.moe) - Unofficial MyAnimeList API

## What Was Added

### 1. API Integration (Jikan API)
- **Purpose**: Search for anime and auto-fill information
- **Endpoint**: `https://api.jikan.moe/v4/anime`
- **No authentication required** - free to use
- **Features**: Returns anime title, image, episodes, synopsis

### 2. Main Features

#### Search & Add Anime (`/anime`)
- Search box to find anime from MyAnimeList database
- Display search results as cards with poster and title
- Select an anime to add to your personal list
- Add to one of three categories:
  - Finished Animes
  - Still Watching Animes
  - Going to Watch Animes

#### Personal Details
- **Details/Notes**: Text area to write your thoughts about the anime
- **Rating**: Scale from 0-10 (default 5)
- Both are saved with each anime entry

### 3. Sub-Pages (Categories)

| Page | URL | Description |
|------|-----|-------------|
| Finished Animes | `/anime/finished` | Animes you've completed |
| Watching Animes | `/anime/watching` | Animes you're currently watching |
| Going to Watch | `/anime/goingtowatch` | Animes you plan to watch |

Each page:
- Shows saved animes with poster, title, episodes count, and rating
- Click on an anime to open the detail page
- Hover effect with shadow

### 4. Detail Page (`/anime/details/{id}`)
- Shows full information when you click an anime
- Includes: poster, title, episodes, category, rating
- Your personal notes/details
- Synopsis from the API

### 5. Data Persistence
- Uses **localStorage** (browser storage)
- Data persists after page refresh
- Stored as JSON in browser

## Files Created/Modified

### New Files
| File | Description |
|------|-------------|
| `AnimeItem.cs` | Model class for saved anime entries |
| `Anime.razor` | Main search and add page |
| `Finished.razor` | Finished animes list |
| `Watching.razor` | Watching animes list |
| `GoingToWatch.razor` | Going to watch list |
| `AnimeDetails.razor` | Detail page (requires `{MalId}` parameter) |
| `FinishedAnimes/` | Folder for category (empty placeholder) |
| `WatchingAnimes/` | Folder for category (empty placeholder) |
| `GoingToWatchAnimes/` | Folder for category (empty placeholder) |

### Modified Files
| File | Changes |
|------|---------|
| `NavMenu.razor` | Added Anime navigation link |
| `Program.cs` | Added HttpClient for API calls |
| `app.css` | Added styling for anime features |

## Code Structure

### `AnimeItem.cs`
```csharp
public class AnimeItem
{
    public int MalId { get; set; }          // MyAnimeList ID
    public string? Title { get; set; }     // Anime title
    public string? ImageUrl { get; set; }    // Poster image URL
    public string? Synopsis { get; set; }     // Description from API
    public int? Episodes { get; set; }      // Episode count
    public string? Status { get; set; }   // API status (Finished/Airing)
    public string WatchStatus { get; set; } // User's category
    public string? Details { get; set; }    // User's personal notes
    public int Rating { get; set; }       // User's rating (0-10)
}
```

### API Integration (Jikan)
```csharp
// Search for anime
var response = await Http.GetFromJsonAsync<JikanSearchResponse>(
    $"anime?q={searchQuery}&limit=10");

// Response contains: title, images, synopsis, episodes
```

### LocalStorage (Data Saving)
```csharp
// Save to storage
var json = System.Text.Json.JsonSerializer.Serialize(animeList);
await JS.InvokeVoidAsync("localStorage.setItem", "animeList", json);

// Load from storage
var saved = await JS.InvokeAsync<string>("localStorage.getItem", "animeList");
animeList = System.Text.Json.JsonSerializer.Deserialize<List<AnimeItem>>(saved);
```

## How to Run

```bash
cd "C:\Users\Salima\OneDrive - HTL Spengergasse\Desktop\3AHWII\SWP-2025-26\2026-04-15_2025_Blazor\BlazorApp1"
dotnet run
```

Then open: **http://localhost:5080/anime**

## Navigation

1. **http://localhost:5080/anime** - Main page (search and add)
2. **http://localhost:5080/anime/finished** - Finished animes
3. **http://localhost:5080/anime/watching** - Currently watching
4. **http://localhost:5080/anime/goingtowatch** - Plan to watch
5. **http://localhost:5080/anime/details/{id}** - Detail page (click any anime)

## Notes for Teacher/SWP Project

- Uses **free Jikan API** - no API key needed
- Data stored in browser's **localStorage** - won't require a database
- All CRUD operations work (Create, Read - delete is implemented)
- Responsive design with hover effects
- Clean separation of concerns with separate pages for each category

---
*Generated on April 23, 2026*