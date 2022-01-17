using System.Collections.Generic;
using Movies.Proxy.Responses;

namespace Movies.Services.Responses
{
    public class SearchMovieResponse
    {
        public int Page { get; set; }
        public List<Result> Results { get; set; }
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }

        public SearchMovieResponse Map(SearchMovieProxyResponse moviesProxy)
        {
            var movies = new SearchMovieResponse
            {
                Page = moviesProxy.page,
                TotalPages = moviesProxy.total_pages,
                TotalResults = moviesProxy.total_results,
                Results = new List<Result>()
            };

            foreach (var movieProxy in moviesProxy.results)
            {
                movies.Results.Add(new Result
                {
                    Adult = movieProxy.adult,
                    BackdropPath = movieProxy.backdrop_path,
                    GenreIds = movieProxy.genre_ids,
                    Id = movieProxy.id,
                    OriginalLanguage = movieProxy.original_language,
                    OriginalTitle = movieProxy.original_title,
                    Overview = movieProxy.overview,
                    Popularity = movieProxy.popularity,
                    PosterPath = movieProxy.poster_path,
                    ReleaseDate = movieProxy.release_date,
                    Title = movieProxy.title,
                    Video = movieProxy.video,
                    VoteAverage = movieProxy.vote_average,
                    VoteCount = movieProxy.vote_count
                });
            }

            return movies;
        }
    }

    public class Result
    {
        public string PosterPath { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public string ReleaseDate { get; set; }
        public List<int> GenreIds { get; set; }
        public int Id { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public string Title { get; set; }
        public string BackdropPath { get; set; }
        public double Popularity { get; set; }
        public int VoteCount { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
    }
}