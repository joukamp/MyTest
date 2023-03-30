using MyTest.Models;

namespace MyTest.Services
{
    public interface IMovieService
    {
        Task<LatestMovie> GetLatestMovieAsync();
        Task<NowPlaying> GetNowPlaying();
        Task<MovieDetail> GetDetailAsync(int id);
    }
}
