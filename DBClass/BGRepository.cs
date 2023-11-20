using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDB;
using SQLiteDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BGListDesktop.DBClass
{
    internal class BGRepository
    {
        public readonly Lazy<BGContext> context;

        public BGRepository()
        {
            context = new Lazy<BGContext>(() => new BGContext());
        }

        public bool tryLogin(string email, string password, out Guid userGuid)
        {
            userGuid = Guid.Empty;

            try
            {
                var obj = (from user in context.Value.Users
                           where user.Email == email && user.Password == password
                           select user).Single();
                obj.LastLogin = DateTime.Now;
                userGuid = obj.Id;
                context.Value.Users.Update(obj);
                context.Value.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool TrySignUp(string name, string email, string password, out Exception thrownException)
        {
            //emailExists = default;
            thrownException = new();
            try
            {
                User user = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = email,
                    Password = password,
                    Name = name,
                    DateCreated = DateTime.Now,
                };
                context.Value.Users.Add(user);
                context.Value.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                thrownException = ex;

                return false;
            }
            catch
            {
                thrownException = new("Unknown exception");
                return false;
            }
        }

        public List<Game> getUserGames(Guid guid) 
        {
            if (context.Value.Users.Single(u => u.Id == guid).Games.Any())
                return (List<Game>)(from user in context.Value.Users
                                where user.Id == guid
                                select user.Games);
            else return new List<Game>();
        }
        public List<Addon> getUserAddons(Guid guid) 
        {
            if (context.Value.Users.Single(u => u.Id == guid).Games.Any())
                return (List<Addon>)(from user in context.Value.Users
                                where user.Id == guid
                                select user.Addons);
            else return new List<Addon>();
        }

        public Dictionary<Game, List<Addon>> getUserGamesWithAddonsAttached(Guid guid)
        {
            return (from game in getUserGames(guid)
                   join addon in getUserAddons(guid) on game.Id equals addon.GameId
                   group addon by game into newGroup
                   select newGroup).ToDictionary(gameGroup => gameGroup.Key, gameGroup => gameGroup.ToList());
        }

        public void findGamesAndAdd(Guid userGuid, List<string> games)
        {
            var game = findGameByName(games);
            addGamesToUser(game, userGuid);
        }

        private List<Game> findGameByName(List<string> gameName) => 
            (List<Game>)(from game in gameName select context.Value.Games.First(u => u.Name.Equals(game)));
        
        public bool searchForGames(String gameName, out List<Game> games)
        {
            games = context.Value.Games.Where(
                game => game.Name.ToLower().Contains(gameName.ToLower())).ToList();

            return games.Any();

            //if (context.Value.Games.Any()) 
            //{ 
            //    games = (List<Game>)(from game in context.Value.Games
            //        where game.Name.Contains(gameName)
            //        select game);
            //    return games.Count > 0 ?  true : false;
            //}

            //games = null;
            //return false;
        }

        public void addGameToUser(Game game, Guid userGuid)
        {
            context.Value.Users.Single(user => user.Id == userGuid).Games.Add(game);
            context.Value.SaveChanges();
        }

        public void addGamesToUser(List<Game> games, Guid userGuid) 
        { 
            context.Value.Users.Single(user => user.Id == userGuid).Games.AddRange(games);
            context.Value.SaveChanges();
        }
    }
}
