using MyTest.Models;
using System.Net.Http.Json;

namespace MyTest.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        string latestApi = "https://api.themoviedb.org/3/movie/latest?api_key=47ec7fd89087e33845796b19578d55ad&language=en-US";
        string nowPlayingApi = "https://api.themoviedb.org/3/movie/now_playing?api_key=47ec7fd89087e33845796b19578d55ad&language=en-US&page=1";
        string apiDetail = "https://api.themoviedb.org/3/movie/#?api_key=47ec7fd89087e33845796b19578d55ad&language=en-US";

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieDetail> GetDetailAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<MovieDetail>(apiDetail.Replace("#",id.ToString()));
        }

        public async Task<LatestMovie> GetLatestMovieAsync()
        {
            return await _httpClient.GetFromJsonAsync<LatestMovie>(latestApi);
        }

        public async Task<NowPlaying> GetNowPlaying()
        {
            return await _httpClient.GetFromJsonAsync<NowPlaying>(nowPlayingApi);
        }
    }
}
